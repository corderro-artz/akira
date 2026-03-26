using Akira;

namespace Akira.Windows;

/// <summary>
/// WMI provider for <see cref="PhysicalMemorySnapshot"/>. Queries Win32_PhysicalMemory.
/// </summary>
public sealed class PhysicalMemorySnapshotProvider : WmiCollectionSnapshotProvider<PhysicalMemorySnapshot>
{
    /// <inheritdoc />
    public PhysicalMemorySnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_PhysicalMemory";

    /// <inheritdoc />
    protected override PhysicalMemorySnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Attributes = WmiValueConverter.AsUInt32(p.GetValueOrDefault("Attributes")),
        BankLabel = WmiValueConverter.AsString(p.GetValueOrDefault("BankLabel")),
        Capacity = WmiValueConverter.AsUInt64(p.GetValueOrDefault("Capacity")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        ConfiguredClockSpeed = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfiguredClockSpeed")),
        ConfiguredVoltage = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfiguredVoltage")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        DataWidth = WmiValueConverter.AsUInt16(p.GetValueOrDefault("DataWidth")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DeviceLocator = WmiValueConverter.AsString(p.GetValueOrDefault("DeviceLocator")),
        FormFactor = WmiValueConverter.AsUInt16(p.GetValueOrDefault("FormFactor")),
        HotSwappable = WmiValueConverter.AsBool(p.GetValueOrDefault("HotSwappable")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        InterleaveDataDepth = WmiValueConverter.AsUInt16(p.GetValueOrDefault("InterleaveDataDepth")),
        InterleavePosition = WmiValueConverter.AsUInt32(p.GetValueOrDefault("InterleavePosition")),
        Manufacturer = WmiValueConverter.AsString(p.GetValueOrDefault("Manufacturer")),
        MaxVoltage = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaxVoltage")),
        MemoryType = WmiValueConverter.AsUInt16(p.GetValueOrDefault("MemoryType")),
        MinVoltage = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MinVoltage")),
        Model = WmiValueConverter.AsString(p.GetValueOrDefault("Model")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        OtherIdentifyingInfo = WmiValueConverter.AsString(p.GetValueOrDefault("OtherIdentifyingInfo")),
        PartNumber = WmiValueConverter.AsString(p.GetValueOrDefault("PartNumber")),
        PositionInRow = WmiValueConverter.AsUInt32(p.GetValueOrDefault("PositionInRow")),
        PoweredOn = WmiValueConverter.AsBool(p.GetValueOrDefault("PoweredOn")),
        Removable = WmiValueConverter.AsBool(p.GetValueOrDefault("Removable")),
        Replaceable = WmiValueConverter.AsBool(p.GetValueOrDefault("Replaceable")),
        SerialNumber = WmiValueConverter.AsString(p.GetValueOrDefault("SerialNumber")),
        SKU = WmiValueConverter.AsString(p.GetValueOrDefault("SKU")),
        SMBIOSMemoryType = WmiValueConverter.AsUInt32(p.GetValueOrDefault("SMBIOSMemoryType")),
        Speed = WmiValueConverter.AsUInt32(p.GetValueOrDefault("Speed")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        Tag = WmiValueConverter.AsString(p.GetValueOrDefault("Tag")),
        TotalWidth = WmiValueConverter.AsUInt16(p.GetValueOrDefault("TotalWidth")),
        TypeDetail = WmiValueConverter.AsUInt16(p.GetValueOrDefault("TypeDetail")),
        Version = WmiValueConverter.AsString(p.GetValueOrDefault("Version")),
    };
}
