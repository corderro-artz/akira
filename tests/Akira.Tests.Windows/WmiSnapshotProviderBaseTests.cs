using Vaporsoft.Akira;
using Vaporsoft.Akira.Windows;

namespace Vaporsoft.Akira.Tests.Windows;

public class WmiSnapshotProviderBaseTests
{
    [Fact]
    public async Task GetSnapshotAsync_success_returns_ok()
    {
        var row = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase)
        {
            ["Caption"] = "Test BIOS",
            ["Manufacturer"] = "TestCorp",
        };
        var executor = FakeWmiQueryExecutor.WithSingleRow(row);
        var provider = new BIOSSnapshotProvider(executor);

        var result = await provider.GetSnapshotAsync();

        Assert.True(result.Success);
        Assert.NotNull(result.Data);
        Assert.Equal("Test BIOS", result.Data!.Caption);
        Assert.Equal("TestCorp", result.Data.Manufacturer);
        Assert.Equal("WMI:Win32_BIOS", result.Source);
        Assert.True(result.DurationMs >= 0);
    }

    [Fact]
    public async Task GetSnapshotAsync_empty_returns_fail()
    {
        var executor = FakeWmiQueryExecutor.Empty();
        var provider = new BIOSSnapshotProvider(executor);

        var result = await provider.GetSnapshotAsync();

        Assert.False(result.Success);
        Assert.Null(result.Data);
        Assert.Contains("No instances returned", result.Error);
    }

    [Fact]
    public async Task GetSnapshotAsync_exception_returns_fail()
    {
        var executor = new FakeWmiQueryExecutor(new InvalidOperationException("WMI broke"));
        var provider = new BIOSSnapshotProvider(executor);

        var result = await provider.GetSnapshotAsync();

        Assert.False(result.Success);
        Assert.Equal("WMI broke", result.Error);
    }

    [Fact]
    public async Task GetSnapshotAsync_queries_correct_namespace_and_class()
    {
        var executor = FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>());
        var provider = new BIOSSnapshotProvider(executor);

        await provider.GetSnapshotAsync();

        Assert.Equal(@"root\CIMV2", executor.LastNamespace);
        Assert.Equal("SELECT * FROM Win32_BIOS", executor.LastQuery);
    }

    [Fact]
    public async Task GetSnapshotAsync_maps_null_properties_gracefully()
    {
        // Empty row - all properties should map to null without throwing
        var executor = FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>());
        var provider = new BaseBoardSnapshotProvider(executor);

        var result = await provider.GetSnapshotAsync();

        Assert.True(result.Success);
        Assert.NotNull(result.Data);
        Assert.Null(result.Data!.Caption);
        Assert.Null(result.Data.Manufacturer);
    }
}
