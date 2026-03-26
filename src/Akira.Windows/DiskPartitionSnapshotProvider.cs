using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="DiskPartitionSnapshot"/>. Queries Win32_DiskPartition.
/// </summary>
public sealed class DiskPartitionSnapshotProvider : WmiCollectionSnapshotProvider<DiskPartitionSnapshot>
{
    /// <inheritdoc />
    public DiskPartitionSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_DiskPartition";

    /// <inheritdoc />
    protected override DiskPartitionSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        AdditionalAvailability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("AdditionalAvailability")),
        Access = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Access")),
        Availability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Availability")),
        BlockSize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("BlockSize")),
        Bootable = WmiValueConverter.AsBool(p.GetValueOrDefault("Bootable")),
        BootPartition = WmiValueConverter.AsBool(p.GetValueOrDefault("BootPartition")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        ConfigManagerErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfigManagerErrorCode")),
        ConfigManagerUserConfig = WmiValueConverter.AsBool(p.GetValueOrDefault("ConfigManagerUserConfig")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("DeviceID")),
        DiskIndex = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DiskIndex")),
        ErrorCleared = WmiValueConverter.AsBool(p.GetValueOrDefault("ErrorCleared")),
        ErrorDescription = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorDescription")),
        ErrorMethodology = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorMethodology")),
        HiddenSectors = WmiValueConverter.AsUInt32(p.GetValueOrDefault("HiddenSectors")),
        IdentifyingDescriptions = WmiValueConverter.AsStringArray(p.GetValueOrDefault("IdentifyingDescriptions")),
        Index = WmiValueConverter.AsUInt32(p.GetValueOrDefault("Index")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        LastErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("LastErrorCode")),
        MaxQuiesceTime = WmiValueConverter.AsUInt64(p.GetValueOrDefault("MaxQuiesceTime")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        NumberOfBlocks = WmiValueConverter.AsUInt64(p.GetValueOrDefault("NumberOfBlocks")),
        OtherIdentifyingInfo = WmiValueConverter.AsUInt64(p.GetValueOrDefault("OtherIdentifyingInfo")),
        PNPDeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("PNPDeviceID")),
        PowerManagementCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PowerManagementCapabilities")),
        PowerManagementSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("PowerManagementSupported")),
        PowerOnHours = WmiValueConverter.AsUInt64(p.GetValueOrDefault("PowerOnHours")),
        PrimaryPartition = WmiValueConverter.AsBool(p.GetValueOrDefault("PrimaryPartition")),
        Purpose = WmiValueConverter.AsString(p.GetValueOrDefault("Purpose")),
        RewritePartition = WmiValueConverter.AsBool(p.GetValueOrDefault("RewritePartition")),
        Size = WmiValueConverter.AsUInt64(p.GetValueOrDefault("Size")),
        StartingOffset = WmiValueConverter.AsUInt64(p.GetValueOrDefault("StartingOffset")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        StatusInfo = WmiValueConverter.AsUInt16(p.GetValueOrDefault("StatusInfo")),
        SystemCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemCreationClassName")),
        SystemName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemName")),
        TotalPowerOnHours = WmiValueConverter.AsUInt64(p.GetValueOrDefault("TotalPowerOnHours")),
        Type = WmiValueConverter.AsString(p.GetValueOrDefault("Type")),
    };
}
