using Vaporsoft.Akira.Windows;

namespace Vaporsoft.Akira.Tests.Windows;

public class SingletonProviderMapTests
{
    // ── BaseBoardSnapshotProvider ─────────────────────────────────────

    [Fact]
    public async Task BaseBoard_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "Base Board",
            ["Manufacturer"] = "ASUS",
            ["Product"] = "ROG STRIX",
            ["SerialNumber"] = "SN123",
            ["HostingBoard"] = true,
            ["Depth"] = 12.5f,
            ["ConfigOptions"] = new[] { "opt1", "opt2" },
            ["InstallDate"] = "20240101120000.000000+000",
        };
        var provider = new BaseBoardSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));

        var result = await provider.GetSnapshotAsync();

        Assert.True(result.Success);
        var d = result.Data!;
        Assert.Equal("Base Board", d.Caption);
        Assert.Equal("ASUS", d.Manufacturer);
        Assert.Equal("ROG STRIX", d.Product);
        Assert.Equal("SN123", d.SerialNumber);
        Assert.True(d.HostingBoard);
        Assert.Equal(12.5f, d.Depth);
        Assert.Equal(new[] { "opt1", "opt2" }, d.ConfigOptions);
        Assert.NotNull(d.InstallDate);
    }

    [Fact]
    public async Task BaseBoard_maps_empty_dict()
    {
        var provider = new BaseBoardSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data!.Caption);
    }

    // ── BIOSSnapshotProvider ──────────────────────────────────────────

    [Fact]
    public async Task BIOS_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "BIOS Date",
            ["Manufacturer"] = "American Megatrends",
            ["SMBIOSBIOSVersion"] = "1.80",
            ["SMBIOSMajorVersion"] = (ushort)3,
            ["SMBIOSMinorVersion"] = (ushort)1,
            ["PrimaryBIOS"] = true,
            ["EmbeddedControllerMajorVersion"] = (byte)1,
            ["BiosCharacteristics"] = new ushort[] { 4, 7 },
            ["BIOSVersion"] = new[] { "ALASKA", "1080" },
            ["ListOfLanguages"] = new[] { "en|US" },
        };
        var provider = new BIOSSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));

        var result = await provider.GetSnapshotAsync();

        Assert.True(result.Success);
        var d = result.Data!;
        Assert.Equal("BIOS Date", d.Caption);
        Assert.Equal("American Megatrends", d.Manufacturer);
        Assert.Equal("1.80", d.SMBIOSBIOSVersion);
        Assert.Equal((ushort)3, d.SMBIOSMajorVersion);
        Assert.True(d.PrimaryBIOS);
        Assert.Equal((byte)1, d.EmbeddedControllerMajorVersion);
        Assert.Equal(new ushort[] { 4, 7 }, d.BiosCharacteristics);
        Assert.Equal(new[] { "ALASKA", "1080" }, d.BIOSVersion);
    }

    [Fact]
    public async Task BIOS_maps_empty_dict()
    {
        var provider = new BIOSSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data!.Caption);
    }

    // ── ComputerSystemSnapshotProvider ────────────────────────────────

    [Fact]
    public async Task ComputerSystem_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "DESKTOP-ABC",
            ["DNSHostName"] = "desktop-abc",
            ["Domain"] = "WORKGROUP",
            ["Manufacturer"] = "Dell",
            ["Model"] = "XPS 15",
            ["NumberOfLogicalProcessors"] = 16U,
            ["NumberOfProcessors"] = 1U,
            ["TotalPhysicalMemory"] = 34359738368UL,
            ["SystemType"] = "x64-based PC",
            ["HypervisorPresent"] = true,
            ["UserName"] = @"DESKTOP\User",
            ["CurrentTimeZone"] = (short)-300,
            ["BootStatus"] = new ushort[] { 0, 0, 0 },
            ["OEMLogoBitmap"] = new byte[] { 0xFF },
            ["Roles"] = new[] { "LM_Workstation" },
            ["PauseAfterReset"] = -1L,
        };
        var provider = new ComputerSystemSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));

        var result = await provider.GetSnapshotAsync();

        Assert.True(result.Success);
        var d = result.Data!;
        Assert.Equal("DESKTOP-ABC", d.Caption);
        Assert.Equal("desktop-abc", d.DNSHostName);
        Assert.Equal("Dell", d.Manufacturer);
        Assert.Equal(16U, d.NumberOfLogicalProcessors);
        Assert.Equal(34359738368UL, d.TotalPhysicalMemory);
        Assert.True(d.HypervisorPresent);
        Assert.Equal((short)-300, d.CurrentTimeZone);
        Assert.Equal(new ushort[] { 0, 0, 0 }, d.BootStatus);
        Assert.Equal(-1L, d.PauseAfterReset);
    }

    [Fact]
    public async Task ComputerSystem_maps_empty_dict()
    {
        var provider = new ComputerSystemSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data!.Caption);
    }

    // ── ComputerSystemProductSnapshotProvider ─────────────────────────

    [Fact]
    public async Task ComputerSystemProduct_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "Computer System Product",
            ["Name"] = "XPS 15 9520",
            ["UUID"] = "4C4C4544-0030-3010-8036-B7C04F575031",
            ["Vendor"] = "Dell Inc.",
            ["Version"] = "1.0",
            ["IdentifyingNumber"] = "ABC123",
            ["SKUNumber"] = "SKU001",
            ["Description"] = "Laptop",
        };
        var provider = new ComputerSystemProductSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));

        var result = await provider.GetSnapshotAsync();

        Assert.True(result.Success);
        var d = result.Data!;
        Assert.Equal("Computer System Product", d.Caption);
        Assert.Equal("XPS 15 9520", d.Name);
        Assert.Equal("4C4C4544-0030-3010-8036-B7C04F575031", d.UUID);
        Assert.Equal("Dell Inc.", d.Vendor);
        Assert.Equal("ABC123", d.IdentifyingNumber);
        Assert.Equal("SKU001", d.SKUNumber);
    }

    [Fact]
    public async Task ComputerSystemProduct_maps_empty_dict()
    {
        var provider = new ComputerSystemProductSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data!.Caption);
    }

    // ── OperatingSystemSnapshotProvider ───────────────────────────────

    [Fact]
    public async Task OperatingSystem_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "Microsoft Windows 11 Pro",
            ["BuildNumber"] = "22631",
            ["Version"] = "10.0.22631",
            ["OSArchitecture"] = "64-bit",
            ["SerialNumber"] = "00331-10000-00001-AA123",
            ["TotalVisibleMemorySize"] = 33554432UL,
            ["FreePhysicalMemory"] = 16777216UL,
            ["NumberOfProcesses"] = 300U,
            ["NumberOfUsers"] = 2U,
            ["CurrentTimeZone"] = (short)-300,
            ["LastBootUpTime"] = "20240115080000.000000+000",
            ["InstallDate"] = "20230601120000.000000+000",
            ["Debug"] = false,
            ["EncryptionLevel"] = 256U,
            ["DataExecutionPrevention_Available"] = true,
            ["MUILanguages"] = new[] { "en-US" },
            ["OperatingSystemSKU"] = 48U,
            ["ServicePackMajorVersion"] = (ushort)0,
            ["DataExecutionPrevention_SupportPolicy"] = (byte)2,
            ["ForegroundApplicationBoost"] = (byte)2,
            ["QuantumLength"] = (byte)0,
            ["QuantumType"] = (byte)0,
            ["OSType"] = (ushort)18,
        };
        var provider = new OperatingSystemSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));

        var result = await provider.GetSnapshotAsync();

        Assert.True(result.Success);
        var d = result.Data!;
        Assert.Equal("Microsoft Windows 11 Pro", d.Caption);
        Assert.Equal("22631", d.BuildNumber);
        Assert.Equal("64-bit", d.OSArchitecture);
        Assert.Equal(33554432UL, d.TotalVisibleMemorySize);
        Assert.Equal(300U, d.NumberOfProcesses);
        Assert.Equal((short)-300, d.CurrentTimeZone);
        Assert.NotNull(d.LastBootUpTime);
        Assert.True(d.DataExecutionPrevention_Available);
        Assert.Equal(new[] { "en-US" }, d.MUILanguages);
        Assert.Equal(48U, d.OperatingSystemSKU);
        Assert.Equal((ushort)0, d.ServicePackMajorVersion);
        Assert.Equal((byte)2, d.DataExecutionPrevention_SupportPolicy);
        Assert.Equal((ushort)18, d.OSType);
    }

    [Fact]
    public async Task OperatingSystem_maps_empty_dict()
    {
        var provider = new OperatingSystemSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data!.Caption);
    }

    // ── TimeZoneSnapshotProvider ──────────────────────────────────────

    [Fact]
    public async Task TimeZone_maps_populated_properties()
    {
        var row = new Dictionary<string, object?>
        {
            ["Caption"] = "(UTC-05:00) Eastern Time",
            ["Bias"] = -300,
            ["DaylightBias"] = -60,
            ["DaylightName"] = "Eastern Daylight Time",
            ["StandardName"] = "Eastern Standard Time",
            ["StandardBias"] = 0U,
            ["DaylightDay"] = 2U,
            ["DaylightDayOfWeek"] = (byte)0,
            ["DaylightHour"] = 2U,
            ["DaylightMonth"] = 3U,
            ["StandardDay"] = 1U,
            ["StandardDayOfWeek"] = (byte)0,
            ["StandardHour"] = 2U,
            ["StandardMonth"] = 11U,
            ["SettingID"] = "tz001",
        };
        var provider = new TimeZoneSnapshotProvider(FakeWmiQueryExecutor.WithSingleRow(row));

        var result = await provider.GetSnapshotAsync();

        Assert.True(result.Success);
        var d = result.Data!;
        Assert.Equal("(UTC-05:00) Eastern Time", d.Caption);
        Assert.Equal(-300, d.Bias);
        Assert.Equal(-60, d.DaylightBias);
        Assert.Equal("Eastern Daylight Time", d.DaylightName);
        Assert.Equal("Eastern Standard Time", d.StandardName);
        Assert.Equal(0U, d.StandardBias);
        Assert.Equal(2U, d.DaylightDay);
        Assert.Equal((byte)0, d.DaylightDayOfWeek);
        Assert.Equal("tz001", d.SettingID);
    }

    [Fact]
    public async Task TimeZone_maps_empty_dict()
    {
        var provider = new TimeZoneSnapshotProvider(
            FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>()));
        var result = await provider.GetSnapshotAsync();
        Assert.True(result.Success);
        Assert.Null(result.Data!.Caption);
    }
}
