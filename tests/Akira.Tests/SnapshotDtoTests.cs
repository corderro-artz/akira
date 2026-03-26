using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Tests;

/// <summary>
/// Tests that all snapshot DTOs have working init-only properties.
/// </summary>
public class SnapshotDtoTests
{
    [Fact]
    public void BaseBoardSnapshot_properties()
    {
        var s = new BaseBoardSnapshot { Caption = "MB", Manufacturer = "ASUS", Product = "ROG", SerialNumber = "123" };
        Assert.Equal("MB", s.Caption);
        Assert.Equal("ASUS", s.Manufacturer);
        Assert.Equal("ROG", s.Product);
        Assert.Equal("123", s.SerialNumber);
    }

    [Fact]
    public void BatterySnapshot_properties()
    {
        var s = new BatterySnapshot { Caption = "Bat", EstimatedChargeRemaining = 85, Chemistry = 2 };
        Assert.Equal("Bat", s.Caption);
        Assert.Equal((ushort)85, s.EstimatedChargeRemaining);
        Assert.Equal((ushort)2, s.Chemistry);
    }

    [Fact]
    public void BIOSSnapshot_properties()
    {
        var s = new BIOSSnapshot { Caption = "BIOS", SMBIOSPresent = true, BIOSVersion = new[] { "v1", "v2" } };
        Assert.Equal("BIOS", s.Caption);
        Assert.True(s.SMBIOSPresent);
        Assert.Equal(2, s.BIOSVersion!.Length);
    }

    [Fact]
    public void ComputerSystemProductSnapshot_properties()
    {
        var s = new ComputerSystemProductSnapshot { Name = "PC", UUID = "abc-123", Vendor = "Dell" };
        Assert.Equal("PC", s.Name);
        Assert.Equal("abc-123", s.UUID);
        Assert.Equal("Dell", s.Vendor);
    }

    [Fact]
    public void ComputerSystemSnapshot_properties()
    {
        var s = new ComputerSystemSnapshot
        {
            Name = "DESKTOP",
            TotalPhysicalMemory = 34359738368,
            NumberOfProcessors = 1,
            HypervisorPresent = true,
        };
        Assert.Equal("DESKTOP", s.Name);
        Assert.Equal(34359738368UL, s.TotalPhysicalMemory);
        Assert.Equal(1U, s.NumberOfProcessors);
        Assert.True(s.HypervisorPresent);
    }

    [Fact]
    public void DesktopMonitorSnapshot_properties()
    {
        var s = new DesktopMonitorSnapshot { Caption = "Monitor", ScreenWidth = 1920, ScreenHeight = 1080 };
        Assert.Equal("Monitor", s.Caption);
        Assert.Equal(1920U, s.ScreenWidth);
        Assert.Equal(1080U, s.ScreenHeight);
    }

    [Fact]
    public void DiskDriveSnapshot_properties()
    {
        var s = new DiskDriveSnapshot { Model = "NVMe", Size = 512110190592, InterfaceType = "SCSI" };
        Assert.Equal("NVMe", s.Model);
        Assert.Equal(512110190592UL, s.Size);
        Assert.Equal("SCSI", s.InterfaceType);
    }

    [Fact]
    public void DiskPartitionSnapshot_properties()
    {
        var s = new DiskPartitionSnapshot { Bootable = true, Size = 100000, Type = "GPT: System" };
        Assert.True(s.Bootable);
        Assert.Equal(100000UL, s.Size);
        Assert.Equal("GPT: System", s.Type);
    }

    [Fact]
    public void EnvironmentSnapshot_properties()
    {
        var s = new EnvironmentSnapshot { Name = "PATH", VariableValue = "C:\\Windows", SystemVariable = true };
        Assert.Equal("PATH", s.Name);
        Assert.Equal("C:\\Windows", s.VariableValue);
        Assert.True(s.SystemVariable);
    }

    [Fact]
    public void FanSnapshot_properties()
    {
        var s = new FanSnapshot { ActiveCooling = true, DesiredSpeed = 3000, VariableSpeed = true };
        Assert.True(s.ActiveCooling);
        Assert.Equal(3000UL, s.DesiredSpeed);
        Assert.True(s.VariableSpeed);
    }

    [Fact]
    public void LogicalDiskSnapshot_properties()
    {
        var s = new LogicalDiskSnapshot { DeviceID = "C:", FreeSpace = 100000000, FileSystem = "NTFS" };
        Assert.Equal("C:", s.DeviceID);
        Assert.Equal(100000000UL, s.FreeSpace);
        Assert.Equal("NTFS", s.FileSystem);
    }

    [Fact]
    public void NetworkAdapterSnapshot_properties()
    {
        var s = new NetworkAdapterSnapshot { Name = "Ethernet", MACAddress = "AA:BB:CC:DD:EE:FF", Speed = 1000000000 };
        Assert.Equal("Ethernet", s.Name);
        Assert.Equal("AA:BB:CC:DD:EE:FF", s.MACAddress);
        Assert.Equal(1000000000UL, s.Speed);
    }

    [Fact]
    public void NetworkAdapterConfigurationSnapshot_properties()
    {
        var s = new NetworkAdapterConfigurationSnapshot
        {
            DHCPEnabled = true,
            IPAddress = new[] { "192.168.1.1" },
            MACAddress = "AA:BB:CC:DD:EE:FF",
        };
        Assert.True(s.DHCPEnabled);
        Assert.Single(s.IPAddress!);
        Assert.Equal("AA:BB:CC:DD:EE:FF", s.MACAddress);
    }

    [Fact]
    public void OperatingSystemSnapshot_properties()
    {
        var s = new OperatingSystemSnapshot { Caption = "Windows 11", Version = "10.0.26100", OSArchitecture = "64-bit" };
        Assert.Equal("Windows 11", s.Caption);
        Assert.Equal("10.0.26100", s.Version);
        Assert.Equal("64-bit", s.OSArchitecture);
    }

    [Fact]
    public void PhysicalMemorySnapshot_properties()
    {
        var s = new PhysicalMemorySnapshot { Capacity = 17179869184, Speed = 3200, Manufacturer = "Samsung" };
        Assert.Equal(17179869184UL, s.Capacity);
        Assert.Equal(3200U, s.Speed);
        Assert.Equal("Samsung", s.Manufacturer);
    }

    [Fact]
    public void PrinterSnapshot_properties()
    {
        var s = new PrinterSnapshot { Name = "HP Printer", Default = true, PortName = "USB001" };
        Assert.Equal("HP Printer", s.Name);
        Assert.True(s.Default);
        Assert.Equal("USB001", s.PortName);
    }

    [Fact]
    public void ProcessorSnapshot_properties()
    {
        var s = new ProcessorSnapshot { Name = "i9-13900K", NumberOfCores = 24, MaxClockSpeed = 5800 };
        Assert.Equal("i9-13900K", s.Name);
        Assert.Equal(24U, s.NumberOfCores);
        Assert.Equal(5800U, s.MaxClockSpeed);
    }

    [Fact]
    public void ProcessSnapshot_properties()
    {
        var s = new ProcessSnapshot { Name = "explorer.exe", ProcessId = 1234, ThreadCount = 50 };
        Assert.Equal("explorer.exe", s.Name);
        Assert.Equal(1234U, s.ProcessId);
        Assert.Equal(50U, s.ThreadCount);
    }

    [Fact]
    public void ServiceSnapshot_properties()
    {
        var s = new ServiceSnapshot { Name = "Spooler", State = "Running", StartMode = "Auto" };
        Assert.Equal("Spooler", s.Name);
        Assert.Equal("Running", s.State);
        Assert.Equal("Auto", s.StartMode);
    }

    [Fact]
    public void SoundDeviceSnapshot_properties()
    {
        var s = new SoundDeviceSnapshot { Name = "Realtek Audio", Manufacturer = "Realtek" };
        Assert.Equal("Realtek Audio", s.Name);
        Assert.Equal("Realtek", s.Manufacturer);
    }

    [Fact]
    public void StartupCommandSnapshot_properties()
    {
        var s = new StartupCommandSnapshot { Name = "OneDrive", Command = "C:\\OneDrive.exe", User = "Admin" };
        Assert.Equal("OneDrive", s.Name);
        Assert.Equal("C:\\OneDrive.exe", s.Command);
        Assert.Equal("Admin", s.User);
    }

    [Fact]
    public void ThermalZoneTemperatureSnapshot_properties()
    {
        var s = new ThermalZoneTemperatureSnapshot { CurrentTemperature = 3150, InstanceName = "Zone0" };
        Assert.Equal(3150U, s.CurrentTemperature);
        Assert.Equal("Zone0", s.InstanceName);
    }

    [Fact]
    public void TimeZoneSnapshot_properties()
    {
        var s = new TimeZoneSnapshot { Bias = -480, StandardName = "PST", DaylightName = "PDT" };
        Assert.Equal(-480, s.Bias);
        Assert.Equal("PST", s.StandardName);
        Assert.Equal("PDT", s.DaylightName);
    }

    [Fact]
    public void UserAccountSnapshot_properties()
    {
        var s = new UserAccountSnapshot { Name = "Admin", SID = "S-1-5-21-xxx", LocalAccount = true };
        Assert.Equal("Admin", s.Name);
        Assert.Equal("S-1-5-21-xxx", s.SID);
        Assert.True(s.LocalAccount);
    }

    [Fact]
    public void VideoControllerSnapshot_properties()
    {
        var s = new VideoControllerSnapshot { Name = "RTX 4090", AdapterRAM = 1073741824U, DriverVersion = "551.23" };
        Assert.Equal("RTX 4090", s.Name);
        Assert.Equal(1073741824U, s.AdapterRAM);
        Assert.Equal("551.23", s.DriverVersion);
    }

    [Fact]
    public void VolumeSnapshot_properties()
    {
        var s = new VolumeSnapshot { DriveLetter = "C:", FileSystem = "NTFS", Capacity = 500000000000 };
        Assert.Equal("C:", s.DriveLetter);
        Assert.Equal("NTFS", s.FileSystem);
        Assert.Equal(500000000000UL, s.Capacity);
    }
}
