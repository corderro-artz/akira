using Akira.Windows;

namespace Akira.Tests.Windows;

public class CollectionProviderMapTests
{
    // ── BatterySnapshotProvider ───────────────────────────────────────

    [Fact]
    public async Task Battery_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "Internal Battery",
            ["BatteryStatus"] = (ushort)2,
            ["Chemistry"] = (ushort)6,
            ["DesignCapacity"] = 60000U,
            ["DesignVoltage"] = 11400UL,
            ["DeviceID"] = "BAT0",
            ["EstimatedChargeRemaining"] = (ushort)82,
            ["EstimatedRunTime"] = 240U,
            ["PowerManagementCapabilities"] = new ushort[] { 1, 4 },
            ["PowerManagementSupported"] = true,
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new BatterySnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("Internal Battery", d.Caption);
        Assert.Equal((ushort)2, d.BatteryStatus);
        Assert.Equal(60000U, d.DesignCapacity);
        Assert.Equal(11400UL, d.DesignVoltage);
        Assert.Equal((ushort)82, d.EstimatedChargeRemaining);
    }

    [Fact]
    public async Task Battery_maps_empty_dict()
    {
        var provider = new BatterySnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── DesktopMonitorSnapshotProvider ────────────────────────────────

    [Fact]
    public async Task DesktopMonitor_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "Dell U2720Q",
            ["MonitorManufacturer"] = "Dell Inc.",
            ["MonitorType"] = "Dell U2720Q",
            ["ScreenWidth"] = 3840U,
            ["ScreenHeight"] = 2160U,
            ["PixelsPerXLogicalInch"] = 163U,
            ["DeviceID"] = @"DesktopMonitor1",
            ["Availability"] = (ushort)3,
            ["DisplayType"] = (ushort)4,
            ["PowerManagementCapabilities"] = new ushort[] { 1 },
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new DesktopMonitorSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("Dell U2720Q", d.Caption);
        Assert.Equal("Dell Inc.", d.MonitorManufacturer);
        Assert.Equal(3840U, d.ScreenWidth);
        Assert.Equal(2160U, d.ScreenHeight);
        Assert.Equal((ushort)3, d.Availability);
    }

    [Fact]
    public async Task DesktopMonitor_maps_empty_dict()
    {
        var provider = new DesktopMonitorSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── DiskDriveSnapshotProvider ─────────────────────────────────────

    [Fact]
    public async Task DiskDrive_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "Samsung SSD 970 EVO",
            ["Size"] = 1000204886016UL,
            ["InterfaceType"] = "SCSI",
            ["MediaType"] = "Fixed hard disk media",
            ["Partitions"] = 3U,
            ["SerialNumber"] = "S123456",
            ["Model"] = "Samsung SSD 970 EVO 1TB",
            ["Index"] = 0U,
            ["BytesPerSector"] = 512U,
            ["FirmwareRevision"] = "2B2QEXE7",
            ["Capabilities"] = new ushort[] { 3, 4 },
            ["CapabilityDescriptions"] = new[] { "Random Access", "Supports Writing" },
            ["DefaultBlockSize"] = 512UL,
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new DiskDriveSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("Samsung SSD 970 EVO", d.Caption);
        Assert.Equal(1000204886016UL, d.Size);
        Assert.Equal("SCSI", d.InterfaceType);
        Assert.Equal(3U, d.Partitions);
        Assert.Equal(512U, d.BytesPerSector);
    }

    [Fact]
    public async Task DiskDrive_maps_empty_dict()
    {
        var provider = new DiskDriveSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── DiskPartitionSnapshotProvider ─────────────────────────────────

    [Fact]
    public async Task DiskPartition_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "Disk #0, Partition #0",
            ["Size"] = 104857600UL,
            ["Bootable"] = true,
            ["BootPartition"] = true,
            ["DiskIndex"] = 0U,
            ["Index"] = 0U,
            ["PrimaryPartition"] = true,
            ["BlockSize"] = 512UL,
            ["HiddenSectors"] = 2048U,
            ["NumberOfBlocks"] = 204800UL,
            ["StartingOffset"] = 1048576UL,
            ["Access"] = (ushort)0,
            ["OtherIdentifyingInfo"] = 0UL,
            ["PowerOnHours"] = 1000UL,
            ["IdentifyingDescriptions"] = new[] { "Desc1" },
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new DiskPartitionSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("Disk #0, Partition #0", d.Caption);
        Assert.Equal(104857600UL, d.Size);
        Assert.True(d.Bootable);
        Assert.Equal(0U, d.DiskIndex);
        Assert.True(d.PrimaryPartition);
    }

    [Fact]
    public async Task DiskPartition_maps_empty_dict()
    {
        var provider = new DiskPartitionSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── EnvironmentSnapshotProvider ───────────────────────────────────

    [Fact]
    public async Task Environment_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "PATH",
            ["Name"] = "PATH",
            ["VariableValue"] = @"C:\Windows;C:\Windows\system32",
            ["UserName"] = "<SYSTEM>",
            ["SystemVariable"] = true,
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new EnvironmentSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("PATH", d.Name);
        Assert.Equal(@"C:\Windows;C:\Windows\system32", d.VariableValue);
        Assert.True(d.SystemVariable);
    }

    [Fact]
    public async Task Environment_maps_empty_dict()
    {
        var provider = new EnvironmentSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── FanSnapshotProvider ───────────────────────────────────────────

    [Fact]
    public async Task Fan_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "CPU Fan",
            ["ActiveCooling"] = true,
            ["DesiredSpeed"] = 2000UL,
            ["VariableSpeed"] = true,
            ["Availability"] = (ushort)3,
            ["DeviceID"] = "FAN0",
            ["PowerManagementCapabilities"] = new ushort[] { 1 },
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new FanSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("CPU Fan", d.Caption);
        Assert.True(d.ActiveCooling);
        Assert.Equal(2000UL, d.DesiredSpeed);
        Assert.True(d.VariableSpeed);
    }

    [Fact]
    public async Task Fan_maps_empty_dict()
    {
        var provider = new FanSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── LogicalDiskSnapshotProvider ───────────────────────────────────

    [Fact]
    public async Task LogicalDisk_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "C:",
            ["DeviceID"] = "C:",
            ["DriveType"] = 3U,
            ["FileSystem"] = "NTFS",
            ["FreeSpace"] = 107374182400UL,
            ["Size"] = 499971518464UL,
            ["VolumeName"] = "Windows",
            ["Compressed"] = false,
            ["MediaType"] = 12U,
            ["BlockSize"] = 4096UL,
            ["MaximumComponentLength"] = 255U,
            ["PowerManagementCapabilities"] = new ushort[] { 1 },
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new LogicalDiskSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("C:", d.Caption);
        Assert.Equal("NTFS", d.FileSystem);
        Assert.Equal(107374182400UL, d.FreeSpace);
        Assert.Equal(499971518464UL, d.Size);
        Assert.Equal(3U, d.DriveType);
    }

    [Fact]
    public async Task LogicalDisk_maps_empty_dict()
    {
        var provider = new LogicalDiskSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── NetworkAdapterSnapshotProvider ────────────────────────────────

    [Fact]
    public async Task NetworkAdapter_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "Intel Wi-Fi 6",
            ["MACAddress"] = "AA:BB:CC:DD:EE:FF",
            ["NetConnectionID"] = "Wi-Fi",
            ["NetConnectionStatus"] = (ushort)2,
            ["Speed"] = 1000000000UL,
            ["AdapterType"] = "Ethernet 802.3",
            ["AdapterTypeId"] = (ushort)0,
            ["NetEnabled"] = true,
            ["PhysicalAdapter"] = true,
            ["Index"] = 1U,
            ["InterfaceIndex"] = 5U,
            ["MaxSpeed"] = 1200000000UL,
            ["NetworkAddresses"] = new[] { "10.0.0.1" },
            ["TimeOfLastReset"] = "20240101000000.000000+000",
            ["InstallDate"] = "20240101000000.000000+000",
            ["PowerManagementCapabilities"] = new ushort[] { 1 },
        };
        var provider = new NetworkAdapterSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("Intel Wi-Fi 6", d.Caption);
        Assert.Equal("AA:BB:CC:DD:EE:FF", d.MACAddress);
        Assert.Equal(1000000000UL, d.Speed);
        Assert.True(d.NetEnabled);
        Assert.True(d.PhysicalAdapter);
    }

    [Fact]
    public async Task NetworkAdapter_maps_empty_dict()
    {
        var provider = new NetworkAdapterSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── NetworkAdapterConfigurationSnapshotProvider ───────────────────

    [Fact]
    public async Task NetworkAdapterConfiguration_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "[00000001] Intel Wi-Fi 6",
            ["DHCPEnabled"] = true,
            ["DHCPServer"] = "192.168.1.1",
            ["IPAddress"] = new[] { "192.168.1.100", "fe80::1" },
            ["IPSubnet"] = new[] { "255.255.255.0" },
            ["MACAddress"] = "AA:BB:CC:DD:EE:FF",
            ["DefaultIPGateway"] = new[] { "192.168.1.1" },
            ["DNSServerSearchOrder"] = new[] { "8.8.8.8" },
            ["IPEnabled"] = true,
            ["Index"] = 1U,
            ["InterfaceIndex"] = 5U,
            ["DefaultTOS"] = (byte)0,
            ["DefaultTTL"] = (byte)64,
            ["IGMPLevel"] = (byte)2,
            ["GatewayCostMetric"] = new ushort[] { 0 },
            ["TcpipNetbiosOptions"] = (ushort)0,
            ["TcpWindowSize"] = (ushort)65535,
            ["IPXFrameType"] = new uint[] { 1 },
            ["DHCPLeaseExpires"] = "20240201000000.000000+000",
            ["DHCPLeaseObtained"] = "20240101000000.000000+000",
        };
        var provider = new NetworkAdapterConfigurationSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("[00000001] Intel Wi-Fi 6", d.Caption);
        Assert.True(d.DHCPEnabled);
        Assert.Equal(new[] { "192.168.1.100", "fe80::1" }, d.IPAddress);
        Assert.Equal("AA:BB:CC:DD:EE:FF", d.MACAddress);
        Assert.True(d.IPEnabled);
        Assert.Equal(new uint[] { 1 }, d.IPXFrameType);
        Assert.Equal((byte)64, d.DefaultTTL);
    }

    [Fact]
    public async Task NetworkAdapterConfiguration_maps_empty_dict()
    {
        var provider = new NetworkAdapterConfigurationSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── PhysicalMemorySnapshotProvider ────────────────────────────────

    [Fact]
    public async Task PhysicalMemory_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "Physical Memory",
            ["Capacity"] = 17179869184UL,
            ["Speed"] = 3200U,
            ["Manufacturer"] = "Samsung",
            ["PartNumber"] = "M471A2K43DB1-CWE",
            ["BankLabel"] = "BANK 0",
            ["DeviceLocator"] = "ChannelA-DIMM0",
            ["FormFactor"] = (ushort)12,
            ["MemoryType"] = (ushort)0,
            ["SMBIOSMemoryType"] = 26U,
            ["ConfiguredClockSpeed"] = 3200U,
            ["DataWidth"] = (ushort)64,
            ["TotalWidth"] = (ushort)64,
            ["Attributes"] = 2U,
            ["TypeDetail"] = (ushort)128,
            ["InterleaveDataDepth"] = (ushort)2,
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new PhysicalMemorySnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("Physical Memory", d.Caption);
        Assert.Equal(17179869184UL, d.Capacity);
        Assert.Equal(3200U, d.Speed);
        Assert.Equal("Samsung", d.Manufacturer);
        Assert.Equal((ushort)12, d.FormFactor);
    }

    [Fact]
    public async Task PhysicalMemory_maps_empty_dict()
    {
        var provider = new PhysicalMemorySnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── PrinterSnapshotProvider ───────────────────────────────────────

    [Fact]
    public async Task Printer_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "HP LaserJet",
            ["DriverName"] = "HP Universal Printing PCL 6",
            ["PortName"] = "USB001",
            ["PrinterStatus"] = (ushort)3,
            ["Shared"] = false,
            ["Network"] = false,
            ["Local"] = true,
            ["Default"] = true,
            ["Attributes"] = 8396U,
            ["AveragePagesPerMinute"] = 30U,
            ["Capabilities"] = new ushort[] { 4, 5 },
            ["CapabilityDescriptions"] = new[] { "Copies", "Collation" },
            ["CurrentCapabilities"] = new ushort[] { 4 },
            ["DefaultCapabilities"] = new ushort[] { 5 },
            ["LanguagesSupported"] = new ushort[] { 44 },
            ["PaperSizesSupported"] = new ushort[] { 1, 5 },
            ["AvailableJobSheets"] = new[] { "None" },
            ["CharSetsSupported"] = new[] { "utf-8" },
            ["ErrorInformation"] = new[] { "No error" },
            ["MimeTypesSupported"] = new[] { "application/pdf" },
            ["NaturalLanguagesSupported"] = new[] { "en-US" },
            ["PaperTypesAvailable"] = new[] { "A4" },
            ["PrinterPaperNames"] = new[] { "Letter" },
            ["PowerManagementCapabilities"] = new ushort[] { 1 },
            ["CurrentLanguage"] = (ushort)44,
            ["DefaultLanguage"] = (ushort)44,
            ["DetectedErrorState"] = (ushort)0,
            ["ExtendedDetectedErrorState"] = (ushort)0,
            ["ExtendedPrinterStatus"] = (ushort)2,
            ["HorizontalResolution"] = 600U,
            ["VerticalResolution"] = 600U,
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new PrinterSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("HP LaserJet", d.Caption);
        Assert.Equal("HP Universal Printing PCL 6", d.DriverName);
        Assert.True(d.Default);
        Assert.True(d.Local);
        Assert.Equal(8396U, d.Attributes);
    }

    [Fact]
    public async Task Printer_maps_empty_dict()
    {
        var provider = new PrinterSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── ProcessorSnapshotProvider ─────────────────────────────────────

    [Fact]
    public async Task Processor_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "Intel64 Family 6 Model 154 Stepping 3",
            ["Name"] = "12th Gen Intel(R) Core(TM) i9-12900H",
            ["MaxClockSpeed"] = 5000U,
            ["CurrentClockSpeed"] = 2500U,
            ["NumberOfCores"] = 14U,
            ["NumberOfLogicalProcessors"] = 20U,
            ["NumberOfEnabledCore"] = 14U,
            ["ThreadCount"] = 20U,
            ["Architecture"] = (ushort)9,
            ["AddressWidth"] = (ushort)64,
            ["DataWidth"] = (ushort)64,
            ["LoadPercentage"] = (ushort)15,
            ["L2CacheSize"] = 11264U,
            ["L3CacheSize"] = 24576U,
            ["Family"] = (ushort)198,
            ["Level"] = (ushort)6,
            ["Revision"] = (ushort)39939,
            ["CurrentVoltage"] = (ushort)8,
            ["CpuStatus"] = (ushort)1,
            ["Characteristics"] = 252U,
            ["ProcessorType"] = (ushort)3,
            ["VoltageCaps"] = 0U,
            ["PowerManagementCapabilities"] = new ushort[] { 1 },
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new ProcessorSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("12th Gen Intel(R) Core(TM) i9-12900H", d.Name);
        Assert.Equal(5000U, d.MaxClockSpeed);
        Assert.Equal(14U, d.NumberOfCores);
        Assert.Equal(20U, d.NumberOfLogicalProcessors);
        Assert.Equal((ushort)9, d.Architecture);
    }

    [Fact]
    public async Task Processor_maps_empty_dict()
    {
        var provider = new ProcessorSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── ProcessSnapshotProvider ───────────────────────────────────────

    [Fact]
    public async Task Process_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "explorer.exe",
            ["Name"] = "explorer.exe",
            ["ProcessId"] = 1234U,
            ["ParentProcessId"] = 100U,
            ["HandleCount"] = 800U,
            ["ThreadCount"] = 50U,
            ["WorkingSetSize"] = 104857600UL,
            ["VirtualSize"] = 2147483648UL,
            ["KernelModeTime"] = 100000000UL,
            ["UserModeTime"] = 200000000UL,
            ["Priority"] = 8U,
            ["PrivatePageCount"] = 50000000UL,
            ["ReadOperationCount"] = 500UL,
            ["WriteOperationCount"] = 100UL,
            ["InstallDate"] = "20240101000000.000000+000",
            ["TerminationDate"] = "20240102000000.000000+000",
        };
        var provider = new ProcessSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("explorer.exe", d.Name);
        Assert.Equal(1234U, d.ProcessId);
        Assert.Equal(800U, d.HandleCount);
        Assert.Equal(104857600UL, d.WorkingSetSize);
    }

    [Fact]
    public async Task Process_maps_empty_dict()
    {
        var provider = new ProcessSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── ServiceSnapshotProvider ───────────────────────────────────────

    [Fact]
    public async Task Service_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "Windows Update",
            ["Name"] = "wuauserv",
            ["DisplayName"] = "Windows Update",
            ["State"] = "Running",
            ["StartMode"] = "Manual",
            ["PathName"] = @"C:\Windows\system32\svchost.exe -k netsvcs",
            ["ProcessId"] = 1000U,
            ["Started"] = true,
            ["AcceptPause"] = false,
            ["AcceptStop"] = true,
            ["DelayedAutoStart"] = false,
            ["ServiceType"] = "Share Process",
            ["ExitCode"] = 0U,
            ["TagId"] = 0U,
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new ServiceSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("wuauserv", d.Name);
        Assert.Equal("Running", d.State);
        Assert.Equal("Manual", d.StartMode);
        Assert.True(d.Started);
        Assert.True(d.AcceptStop);
    }

    [Fact]
    public async Task Service_maps_empty_dict()
    {
        var provider = new ServiceSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── SoundDeviceSnapshotProvider ───────────────────────────────────

    [Fact]
    public async Task SoundDevice_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "Realtek High Definition Audio",
            ["Manufacturer"] = "Realtek",
            ["ProductName"] = "Realtek Audio",
            ["DeviceID"] = "HDAUDIO\\0001",
            ["DMABufferSize"] = (ushort)256,
            ["MPU401Address"] = 0U,
            ["Availability"] = (ushort)3,
            ["PowerManagementCapabilities"] = new ushort[] { 1 },
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new SoundDeviceSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("Realtek High Definition Audio", d.Caption);
        Assert.Equal("Realtek", d.Manufacturer);
        Assert.Equal((ushort)256, d.DMABufferSize);
    }

    [Fact]
    public async Task SoundDevice_maps_empty_dict()
    {
        var provider = new SoundDeviceSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── StartupCommandSnapshotProvider ────────────────────────────────

    [Fact]
    public async Task StartupCommand_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "SecurityHealth",
            ["Command"] = @"%ProgramFiles%\Windows Defender\MSASCuiL.exe",
            ["Name"] = "SecurityHealth",
            ["User"] = "Public",
            ["Location"] = @"HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Run",
            ["UserSID"] = "S-1-5-18",
            ["SettingID"] = "startup001",
        };
        var provider = new StartupCommandSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("SecurityHealth", d.Name);
        Assert.Equal(@"%ProgramFiles%\Windows Defender\MSASCuiL.exe", d.Command);
        Assert.Equal("Public", d.User);
        Assert.Equal("S-1-5-18", d.UserSID);
    }

    [Fact]
    public async Task StartupCommand_maps_empty_dict()
    {
        var provider = new StartupCommandSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── ThermalZoneTemperatureSnapshotProvider ────────────────────────

    [Fact]
    public async Task ThermalZone_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["InstanceName"] = @"ACPI\ThermalZone\THM0_0",
            ["Active"] = true,
            ["CurrentTemperature"] = 3132U,
            ["CriticalTripPoint"] = 3732U,
            ["PassiveTripPoint"] = 3632U,
            ["ActiveTripPoint"] = 3432U,
            ["ActiveTripPointCount"] = 1U,
            ["SamplingPeriod"] = 0U,
            ["ThermalConstant1"] = 0U,
            ["ThermalConstant2"] = 0U,
            ["ThermalStamp"] = 0U,
        };
        var provider = new ThermalZoneTemperatureSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal(@"ACPI\ThermalZone\THM0_0", d.InstanceName);
        Assert.True(d.Active);
        Assert.Equal(3132U, d.CurrentTemperature);
        Assert.Equal(3732U, d.CriticalTripPoint);
    }

    [Fact]
    public async Task ThermalZone_maps_empty_dict()
    {
        var provider = new ThermalZoneTemperatureSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].InstanceName);
    }

    // ── UserAccountSnapshotProvider ───────────────────────────────────

    [Fact]
    public async Task UserAccount_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = @"DESKTOP\Admin",
            ["Name"] = "Admin",
            ["Domain"] = "DESKTOP",
            ["SID"] = "S-1-5-21-123456789-1234567890-1234567890-1001",
            ["SIDType"] = (byte)1,
            ["FullName"] = "Administrator",
            ["Disabled"] = false,
            ["LocalAccount"] = true,
            ["Lockout"] = false,
            ["PasswordChangeable"] = true,
            ["PasswordExpires"] = false,
            ["PasswordRequired"] = true,
            ["AccountType"] = 512U,
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new UserAccountSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("Admin", d.Name);
        Assert.Equal("DESKTOP", d.Domain);
        Assert.True(d.LocalAccount);
        Assert.False(d.Disabled);
        Assert.Equal((byte)1, d.SIDType);
    }

    [Fact]
    public async Task UserAccount_maps_empty_dict()
    {
        var provider = new UserAccountSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── VideoControllerSnapshotProvider ───────────────────────────────

    [Fact]
    public async Task VideoController_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "NVIDIA GeForce RTX 3080",
            ["AdapterRAM"] = 1073741824U,
            ["AdapterCompatibility"] = "NVIDIA",
            ["DriverVersion"] = "31.0.15.3623",
            ["CurrentHorizontalResolution"] = 3840U,
            ["CurrentVerticalResolution"] = 2160U,
            ["CurrentBitsPerPixel"] = 32U,
            ["CurrentRefreshRate"] = 144U,
            ["CurrentNumberOfColors"] = 4294967296UL,
            ["VideoProcessor"] = "NVIDIA GeForce RTX 3080",
            ["AcceleratorCapabilities"] = new ushort[] { 2, 3 },
            ["CapabilityDescriptions"] = new[] { "Graphics Accelerator", "3D Accelerator" },
            ["VideoArchitecture"] = (ushort)5,
            ["VideoMemoryType"] = (ushort)2,
            ["VideoMode"] = (ushort)0,
            ["CurrentScanMode"] = (ushort)4,
            ["NumberOfColorPlanes"] = (ushort)1,
            ["ProtocolSupported"] = (ushort)0,
            ["DriverDate"] = "20240101000000.000000+000",
            ["InstallDate"] = "20240101000000.000000+000",
            ["TimeOfLastReset"] = "20240101000000.000000+000",
            ["PowerManagementCapabilities"] = new ushort[] { 1 },
        };
        var provider = new VideoControllerSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal("NVIDIA GeForce RTX 3080", d.Caption);
        Assert.Equal(1073741824U, d.AdapterRAM);
        Assert.Equal("31.0.15.3623", d.DriverVersion);
        Assert.Equal(3840U, d.CurrentHorizontalResolution);
        Assert.Equal(144U, d.CurrentRefreshRate);
    }

    [Fact]
    public async Task VideoController_maps_empty_dict()
    {
        var provider = new VideoControllerSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }

    // ── VolumeSnapshotProvider ────────────────────────────────────────

    [Fact]
    public async Task Volume_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = @"\\?\Volume{abc}",
            ["DriveLetter"] = "C:",
            ["FileSystem"] = "NTFS",
            ["Capacity"] = 499971518464UL,
            ["FreeSpace"] = 107374182400UL,
            ["DriveType"] = 3U,
            ["SerialNumber"] = 12345U,
            ["Automount"] = true,
            ["Compressed"] = false,
            ["BlockSize"] = 4096UL,
            ["NumberOfBlocks"] = 122070312UL,
            ["Access"] = (ushort)0,
            ["PowerManagementCapabilities"] = new ushort[] { 1 },
            ["InstallDate"] = "20240101000000.000000+000",
        };
        var provider = new VolumeSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        var d = result.Data![0];
        Assert.Equal(@"\\?\Volume{abc}", d.Caption);
        Assert.Equal("C:", d.DriveLetter);
        Assert.Equal("NTFS", d.FileSystem);
        Assert.Equal(499971518464UL, d.Capacity);
        Assert.Equal(107374182400UL, d.FreeSpace);
        Assert.True(d.Automount);
    }

    [Fact]
    public async Task Volume_maps_empty_dict()
    {
        var provider = new VolumeSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data![0].Caption);
    }
}
