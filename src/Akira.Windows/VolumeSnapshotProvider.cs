using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="VolumeSnapshot"/>. Queries Win32_Volume.
/// </summary>
public sealed class VolumeSnapshotProvider : WmiCollectionSnapshotProvider<VolumeSnapshot>
{
    /// <inheritdoc />
    public VolumeSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_Volume";

    /// <inheritdoc />
    protected override VolumeSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Access = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Access")),
        Automount = WmiValueConverter.AsBool(p.GetValueOrDefault("Automount")),
        Availability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Availability")),
        BlockSize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("BlockSize")),
        Capacity = WmiValueConverter.AsUInt64(p.GetValueOrDefault("Capacity")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        Compressed = WmiValueConverter.AsBool(p.GetValueOrDefault("Compressed")),
        ConfigManagerErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfigManagerErrorCode")),
        ConfigManagerUserConfig = WmiValueConverter.AsBool(p.GetValueOrDefault("ConfigManagerUserConfig")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("DeviceID")),
        DirtyBitSet = WmiValueConverter.AsBool(p.GetValueOrDefault("DirtyBitSet")),
        DriveLetter = WmiValueConverter.AsString(p.GetValueOrDefault("DriveLetter")),
        DriveType = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DriveType")),
        ErrorCleared = WmiValueConverter.AsBool(p.GetValueOrDefault("ErrorCleared")),
        ErrorDescription = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorDescription")),
        ErrorMethodology = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorMethodology")),
        FileSystem = WmiValueConverter.AsString(p.GetValueOrDefault("FileSystem")),
        FreeSpace = WmiValueConverter.AsUInt64(p.GetValueOrDefault("FreeSpace")),
        IndexingEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("IndexingEnabled")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        Label = WmiValueConverter.AsString(p.GetValueOrDefault("Label")),
        LastErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("LastErrorCode")),
        MaximumFileNameLength = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaximumFileNameLength")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        NumberOfBlocks = WmiValueConverter.AsUInt64(p.GetValueOrDefault("NumberOfBlocks")),
        PNPDeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("PNPDeviceID")),
        PowerManagementCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PowerManagementCapabilities")),
        PowerManagementSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("PowerManagementSupported")),
        Purpose = WmiValueConverter.AsString(p.GetValueOrDefault("Purpose")),
        QuotasEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("QuotasEnabled")),
        QuotasIncomplete = WmiValueConverter.AsBool(p.GetValueOrDefault("QuotasIncomplete")),
        QuotasRebuilding = WmiValueConverter.AsBool(p.GetValueOrDefault("QuotasRebuilding")),
        SerialNumber = WmiValueConverter.AsUInt32(p.GetValueOrDefault("SerialNumber")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        StatusInfo = WmiValueConverter.AsUInt16(p.GetValueOrDefault("StatusInfo")),
        SupportsDiskQuotas = WmiValueConverter.AsBool(p.GetValueOrDefault("SupportsDiskQuotas")),
        SupportsFileBasedCompression = WmiValueConverter.AsBool(p.GetValueOrDefault("SupportsFileBasedCompression")),
        SystemCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemCreationClassName")),
        SystemName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemName")),
    };
}
