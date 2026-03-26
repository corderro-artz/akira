using Akira;
using Akira.Windows;

namespace Akira.Tests.Windows;

public class WmiCollectionSnapshotProviderBaseTests
{
    [Fact]
    public async Task GetSnapshotAsync_success_returns_all_rows()
    {
        var executor = FakeWmiQueryExecutor.WithRows(
            new Dictionary<string, object?> { ["Caption"] = "Battery 1" },
            new Dictionary<string, object?> { ["Caption"] = "Battery 2" });
        var provider = new BatterySnapshotProvider(executor);

        var result = await provider.GetSnapshotAsync();

        Assert.True(result.Success);
        Assert.NotNull(result.Data);
        Assert.Equal(2, result.Data!.Length);
        Assert.Equal("Battery 1", result.Data[0].Caption);
        Assert.Equal("Battery 2", result.Data[1].Caption);
    }

    [Fact]
    public async Task GetSnapshotAsync_empty_returns_empty_array()
    {
        var executor = FakeWmiQueryExecutor.Empty();
        var provider = new BatterySnapshotProvider(executor);

        var result = await provider.GetSnapshotAsync();

        Assert.True(result.Success);
        Assert.NotNull(result.Data);
        Assert.Empty(result.Data!);
    }

    [Fact]
    public async Task GetSnapshotAsync_exception_returns_fail()
    {
        var executor = new FakeWmiQueryExecutor(new InvalidOperationException("WMI broke"));
        var provider = new BatterySnapshotProvider(executor);

        var result = await provider.GetSnapshotAsync();

        Assert.False(result.Success);
        Assert.Equal("WMI broke", result.Error);
    }

    [Fact]
    public async Task GetSnapshotAsync_queries_correct_namespace()
    {
        var executor = FakeWmiQueryExecutor.Empty();
        var provider = new BatterySnapshotProvider(executor);

        await provider.GetSnapshotAsync();

        Assert.Equal(@"root\CIMV2", executor.LastNamespace);
        Assert.Equal("SELECT * FROM Win32_Battery", executor.LastQuery);
    }

    [Fact]
    public async Task ThermalZone_uses_wmi_namespace()
    {
        var executor = FakeWmiQueryExecutor.Empty();
        var provider = new ThermalZoneTemperatureSnapshotProvider(executor);

        await provider.GetSnapshotAsync();

        Assert.Equal(@"root\WMI", executor.LastNamespace);
        Assert.Equal("SELECT * FROM MSAcpi_ThermalZoneTemperature", executor.LastQuery);
    }
}
