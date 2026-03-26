using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Tests;

public class MachineSnapshotTests
{
    [Fact]
    public void Default_instance_has_null_properties()
    {
        var snapshot = new MachineSnapshot();

        Assert.Null(snapshot.MachineName);
        Assert.Null(snapshot.DnsHostName);
        Assert.Null(snapshot.Domain);
        Assert.Null(snapshot.OsDescription);
        Assert.Null(snapshot.OsVersion);
        Assert.Null(snapshot.RuntimeDescription);
        Assert.Null(snapshot.AkiraVersion);
        Assert.Null(snapshot.BIOS);
        Assert.Null(snapshot.BaseBoard);
        Assert.Null(snapshot.Batteries);
        Assert.Null(snapshot.ComputerSystem);
        Assert.Null(snapshot.ComputerSystemProduct);
        Assert.Null(snapshot.DesktopMonitors);
        Assert.Null(snapshot.DiskDrives);
        Assert.Null(snapshot.DiskPartitions);
        Assert.Null(snapshot.EnvironmentVariables);
        Assert.Null(snapshot.Fans);
        Assert.Null(snapshot.LogicalDisks);
        Assert.Null(snapshot.NetworkAdapters);
        Assert.Null(snapshot.NetworkAdapterConfigurations);
        Assert.Null(snapshot.OperatingSystem);
        Assert.Null(snapshot.PhysicalMemory);
        Assert.Null(snapshot.Printers);
        Assert.Null(snapshot.Processors);
        Assert.Null(snapshot.Processes);
        Assert.Null(snapshot.Services);
        Assert.Null(snapshot.SoundDevices);
        Assert.Null(snapshot.StartupCommands);
        Assert.Null(snapshot.ThermalZones);
        Assert.Null(snapshot.TimeZone);
        Assert.Null(snapshot.UserAccounts);
        Assert.Null(snapshot.VideoControllers);
        Assert.Null(snapshot.Volumes);
    }

    [Fact]
    public void Init_properties_can_be_set()
    {
        var now = DateTimeOffset.UtcNow;
        var snapshot = new MachineSnapshot
        {
            MachineName = "TestPC",
            DnsHostName = "testpc.local",
            Domain = "WORKGROUP",
            OsDescription = "Windows 11",
            OsVersion = "10.0.26100",
            RuntimeDescription = ".NET 10.0.0",
            CollectedAtUtc = now,
            AkiraVersion = "0.1.0",
            BIOS = SnapshotResult<BIOSSnapshot>.Ok(new BIOSSnapshot(), "WMI:Win32_BIOS", 1.0),
        };

        Assert.Equal("TestPC", snapshot.MachineName);
        Assert.Equal("testpc.local", snapshot.DnsHostName);
        Assert.Equal("WORKGROUP", snapshot.Domain);
        Assert.Equal("Windows 11", snapshot.OsDescription);
        Assert.Equal("10.0.26100", snapshot.OsVersion);
        Assert.Equal(".NET 10.0.0", snapshot.RuntimeDescription);
        Assert.Equal(now, snapshot.CollectedAtUtc);
        Assert.Equal("0.1.0", snapshot.AkiraVersion);
        Assert.NotNull(snapshot.BIOS);
        Assert.True(snapshot.BIOS!.Success);
    }
}
