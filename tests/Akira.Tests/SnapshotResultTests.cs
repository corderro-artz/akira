using Akira;

namespace Akira.Tests;

public class SnapshotResultTests
{
    [Fact]
    public void Ok_sets_all_properties()
    {
        var data = new BIOSSnapshot { Caption = "Test" };
        var result = SnapshotResult<BIOSSnapshot>.Ok(data, "WMI:Win32_BIOS", 42.5);

        Assert.True(result.Success);
        Assert.True(result.IsSupported);
        Assert.False(result.IsPartial);
        Assert.Same(data, result.Data);
        Assert.Equal("WMI:Win32_BIOS", result.Source);
        Assert.Equal(42.5, result.DurationMs);
        Assert.Null(result.Error);
        Assert.Null(result.Warnings);
        Assert.True(result.CollectedAtUtc <= DateTimeOffset.UtcNow);
        Assert.True(result.CollectedAtUtc > DateTimeOffset.UtcNow.AddSeconds(-5));
    }

    [Fact]
    public void Fail_sets_all_properties()
    {
        var result = SnapshotResult<BIOSSnapshot>.Fail("WMI:Win32_BIOS", "Something broke", 10.0);

        Assert.False(result.Success);
        Assert.True(result.IsSupported);
        Assert.False(result.IsPartial);
        Assert.Null(result.Data);
        Assert.Equal("WMI:Win32_BIOS", result.Source);
        Assert.Equal("Something broke", result.Error);
        Assert.Equal(10.0, result.DurationMs);
        Assert.True(result.CollectedAtUtc <= DateTimeOffset.UtcNow);
    }

    [Fact]
    public void Unsupported_sets_all_properties()
    {
        var result = SnapshotResult<BIOSSnapshot>.Unsupported("WMI:Win32_BIOS");

        Assert.False(result.Success);
        Assert.False(result.IsSupported);
        Assert.False(result.IsPartial);
        Assert.Null(result.Data);
        Assert.Equal("WMI:Win32_BIOS", result.Source);
        Assert.Equal("Not supported on the current platform.", result.Error);
        Assert.Equal(0.0, result.DurationMs);
        Assert.True(result.CollectedAtUtc <= DateTimeOffset.UtcNow);
    }

    [Fact]
    public void Ok_with_array_type()
    {
        var data = new[] { new BatterySnapshot { Caption = "Bat1" } };
        var result = SnapshotResult<BatterySnapshot[]>.Ok(data, "WMI:Win32_Battery", 5.0);

        Assert.True(result.Success);
        Assert.Single(result.Data!);
        Assert.Equal("Bat1", result.Data![0].Caption);
    }

    [Fact]
    public void Warnings_can_be_set_via_init()
    {
        var result = new SnapshotResult<BIOSSnapshot>
        {
            Success = true,
            Warnings = new[] { "Warning 1", "Warning 2" },
            IsPartial = true,
        };

        Assert.True(result.IsPartial);
        Assert.Equal(2, result.Warnings!.Length);
    }
}
