using System.Text.Json;
using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Tests;

public class AkiraJsonContextTests
{
    [Fact]
    public void Can_serialize_MachineSnapshot()
    {
        var snapshot = new MachineSnapshot
        {
            MachineName = "TestPC",
            CollectedAtUtc = DateTimeOffset.UtcNow,
            BIOS = SnapshotResult<BIOSSnapshot>.Ok(
                new BIOSSnapshot { Caption = "BIOS v1.0", Manufacturer = "TestCorp" },
                "WMI:Win32_BIOS", 5.0),
        };

        var json = JsonSerializer.Serialize(snapshot, AkiraJsonContext.Default.MachineSnapshot);

        Assert.NotNull(json);
        Assert.Contains("\"machineName\"", json);
        Assert.Contains("TestPC", json);
        Assert.Contains("BIOS v1.0", json);
    }

    [Fact]
    public void Can_roundtrip_MachineSnapshot()
    {
        var original = new MachineSnapshot
        {
            MachineName = "RoundTrip",
            OsDescription = "Test OS",
        };

        var json = JsonSerializer.Serialize(original, AkiraJsonContext.Default.MachineSnapshot);
        var deserialized = JsonSerializer.Deserialize(json, AkiraJsonContext.Default.MachineSnapshot);

        Assert.NotNull(deserialized);
        Assert.Equal("RoundTrip", deserialized!.MachineName);
        Assert.Equal("Test OS", deserialized.OsDescription);
    }

    [Fact]
    public void Can_serialize_individual_snapshot_dto()
    {
        var bios = new BIOSSnapshot
        {
            Caption = "Test",
            Manufacturer = "Corp",
            SMBIOSPresent = true,
            SMBIOSMajorVersion = 3,
        };

        var json = JsonSerializer.Serialize(bios, AkiraJsonContext.Default.BIOSSnapshot);

        Assert.Contains("\"caption\"", json);
        Assert.Contains("\"manufacturer\"", json);
        Assert.Contains("\"smbiosPresent\"", json);
    }

    [Fact]
    public void Can_serialize_SnapshotResult_with_data()
    {
        var result = SnapshotResult<ProcessorSnapshot[]>.Ok(
            new[] { new ProcessorSnapshot { Name = "CPU0", NumberOfCores = 8 } },
            "WMI:Win32_Processor", 10.0);

        var json = JsonSerializer.Serialize(result, AkiraJsonContext.Default.SnapshotResultProcessorSnapshotArray);

        Assert.Contains("CPU0", json);
        Assert.Contains("\"success\"", json);
    }

    [Fact]
    public void Null_properties_are_omitted()
    {
        var dto = new ComputerSystemProductSnapshot { Name = "Product" };

        var json = JsonSerializer.Serialize(dto, AkiraJsonContext.Default.ComputerSystemProductSnapshot);

        Assert.Contains("\"name\"", json);
        Assert.DoesNotContain("\"caption\"", json);
        Assert.DoesNotContain("\"description\"", json);
    }

    [Fact]
    public void Can_roundtrip_SnapshotResult_fail()
    {
        var result = SnapshotResult<BIOSSnapshot>.Fail("src", "error msg", 1.0);

        var json = JsonSerializer.Serialize(result, AkiraJsonContext.Default.SnapshotResultBIOSSnapshot);
        var back = JsonSerializer.Deserialize(json, AkiraJsonContext.Default.SnapshotResultBIOSSnapshot);

        Assert.NotNull(back);
        Assert.False(back!.Success);
        Assert.Equal("error msg", back.Error);
    }
}
