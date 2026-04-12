using Vaporsoft.Akira;
using Vaporsoft.Akira.Windows;

namespace Vaporsoft.Akira.Tests.Windows;

public class MachineSnapshotCollectorTests
{
    // A fake executor that returns an empty result set for every query.
    // Providers that are collections succeed with an empty array;
    // singleton providers fail with "No instances returned".
    private static FakeWmiQueryExecutor EmptyExecutor() => FakeWmiQueryExecutor.Empty();

    // A fake executor that throws on every query — simulates total WMI failure.
    private static FakeWmiQueryExecutor ThrowingExecutor() =>
        new(new InvalidOperationException("WMI unavailable"));

    [Fact]
    public async Task CollectAsync_metadata_fields_are_always_populated()
    {
        var before = DateTimeOffset.UtcNow;
        var snapshot = await new MachineSnapshotCollector(EmptyExecutor()).CollectAsync();
        var after = DateTimeOffset.UtcNow;

        Assert.NotNull(snapshot.MachineName);
        Assert.NotNull(snapshot.DnsHostName);
        Assert.NotNull(snapshot.OsDescription);
        Assert.NotNull(snapshot.OsVersion);
        Assert.NotNull(snapshot.RuntimeDescription);
        Assert.InRange(snapshot.CollectedAtUtc, before, after);
    }

    [Fact]
    public async Task CollectAsync_all_26_provider_results_are_non_null()
    {
        // Even when providers return empty rows they still produce a SnapshotResult<T>.
        // Every property on MachineSnapshot should be populated (not null).
        var snapshot = await new MachineSnapshotCollector(EmptyExecutor()).CollectAsync();

        Assert.NotNull(snapshot.BaseBoard);
        Assert.NotNull(snapshot.Batteries);
        Assert.NotNull(snapshot.BIOS);
        Assert.NotNull(snapshot.ComputerSystem);
        Assert.NotNull(snapshot.ComputerSystemProduct);
        Assert.NotNull(snapshot.DesktopMonitors);
        Assert.NotNull(snapshot.DiskDrives);
        Assert.NotNull(snapshot.DiskPartitions);
        Assert.NotNull(snapshot.EnvironmentVariables);
        Assert.NotNull(snapshot.Fans);
        Assert.NotNull(snapshot.LogicalDisks);
        Assert.NotNull(snapshot.NetworkAdapters);
        Assert.NotNull(snapshot.NetworkAdapterConfigurations);
        Assert.NotNull(snapshot.OperatingSystem);
        Assert.NotNull(snapshot.PhysicalMemory);
        Assert.NotNull(snapshot.Printers);
        Assert.NotNull(snapshot.Processors);
        Assert.NotNull(snapshot.Processes);
        Assert.NotNull(snapshot.Services);
        Assert.NotNull(snapshot.SoundDevices);
        Assert.NotNull(snapshot.StartupCommands);
        Assert.NotNull(snapshot.ThermalZones);
        Assert.NotNull(snapshot.TimeZone);
        Assert.NotNull(snapshot.UserAccounts);
        Assert.NotNull(snapshot.VideoControllers);
        Assert.NotNull(snapshot.Volumes);
    }

    [Fact]
    public async Task CollectAsync_wmi_failure_does_not_throw_and_marks_results_failed()
    {
        // CollectAsync must complete without throwing even when every WMI call fails.
        var snapshot = await new MachineSnapshotCollector(ThrowingExecutor()).CollectAsync();

        // All results should be present but marked as failures.
        Assert.NotNull(snapshot.BIOS);
        Assert.False(snapshot.BIOS!.Success);
        Assert.NotNull(snapshot.BIOS.Error);

        Assert.NotNull(snapshot.Processors);
        Assert.False(snapshot.Processors!.Success);

        Assert.NotNull(snapshot.DiskDrives);
        Assert.False(snapshot.DiskDrives!.Success);
    }

    [Fact]
    public async Task CollectAsync_partial_failure_does_not_affect_other_providers()
    {
        // A fake executor that succeeds for most queries but throws only for Win32_BIOS.
        var executor = new SelectiveThrowingExecutor(failQuery: "SELECT * FROM Win32_BIOS");
        var snapshot = await new MachineSnapshotCollector(executor).CollectAsync();

        // BIOS should have failed.
        Assert.NotNull(snapshot.BIOS);
        Assert.False(snapshot.BIOS!.Success);

        // Other providers should have succeeded (empty arrays or empty singletons).
        Assert.NotNull(snapshot.Processors);
        Assert.True(snapshot.Processors!.Success);

        Assert.NotNull(snapshot.DiskDrives);
        Assert.True(snapshot.DiskDrives!.Success);
    }

    [Fact]
    public async Task CollectAsync_respects_cancellation()
    {
        using var cts = new CancellationTokenSource();
        cts.Cancel();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(
            () => new MachineSnapshotCollector(EmptyExecutor()).CollectAsync(cts.Token));
    }

    // ---------------------------------------------------------------------------
    // Helper: fake executor that throws only for a specific WQL query string.
    // ---------------------------------------------------------------------------
    private sealed class SelectiveThrowingExecutor : IWmiQueryExecutor
    {
        private readonly string _failQuery;

        public SelectiveThrowingExecutor(string failQuery) => _failQuery = failQuery;

        public IReadOnlyList<IReadOnlyDictionary<string, object?>> Query(
            string wmiNamespace, string wqlQuery)
        {
            if (wqlQuery == _failQuery)
                throw new InvalidOperationException($"Simulated failure for: {wqlQuery}");

            return Array.Empty<IReadOnlyDictionary<string, object?>>();
        }
    }
}
