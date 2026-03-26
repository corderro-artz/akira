using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="LogicalDiskSnapshot"/>. Queries Win32_LogicalDisk.
/// </summary>
public sealed class LogicalDiskSnapshotProvider : WmiCollectionSnapshotProvider<LogicalDiskSnapshot>
{
    /// <inheritdoc />
    public LogicalDiskSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_LogicalDisk";

    /// <inheritdoc />
    protected override LogicalDiskSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Access = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Access")),
        Availability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Availability")),
        BlockSize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("BlockSize")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        Compressed = WmiValueConverter.AsBool(p.GetValueOrDefault("Compressed")),
        ConfigManagerErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfigManagerErrorCode")),
        ConfigManagerUserConfig = WmiValueConverter.AsBool(p.GetValueOrDefault("ConfigManagerUserConfig")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("DeviceID")),
        DriveType = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DriveType")),
        ErrorCleared = WmiValueConverter.AsBool(p.GetValueOrDefault("ErrorCleared")),
        ErrorDescription = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorDescription")),
        ErrorMethodology = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorMethodology")),
        FileSystem = WmiValueConverter.AsString(p.GetValueOrDefault("FileSystem")),
        FreeSpace = WmiValueConverter.AsUInt64(p.GetValueOrDefault("FreeSpace")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        LastErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("LastErrorCode")),
        MaximumComponentLength = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaximumComponentLength")),
        MediaType = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MediaType")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        NumberOfBlocks = WmiValueConverter.AsUInt64(p.GetValueOrDefault("NumberOfBlocks")),
        PNPDeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("PNPDeviceID")),
        PowerManagementCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PowerManagementCapabilities")),
        PowerManagementSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("PowerManagementSupported")),
        ProviderName = WmiValueConverter.AsString(p.GetValueOrDefault("ProviderName")),
        Purpose = WmiValueConverter.AsString(p.GetValueOrDefault("Purpose")),
        QuotasDisabled = WmiValueConverter.AsBool(p.GetValueOrDefault("QuotasDisabled")),
        QuotasIncomplete = WmiValueConverter.AsBool(p.GetValueOrDefault("QuotasIncomplete")),
        QuotasRebuilding = WmiValueConverter.AsBool(p.GetValueOrDefault("QuotasRebuilding")),
        Size = WmiValueConverter.AsUInt64(p.GetValueOrDefault("Size")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        StatusInfo = WmiValueConverter.AsUInt16(p.GetValueOrDefault("StatusInfo")),
        SupportsDiskQuotas = WmiValueConverter.AsBool(p.GetValueOrDefault("SupportsDiskQuotas")),
        SupportsFileBasedCompression = WmiValueConverter.AsBool(p.GetValueOrDefault("SupportsFileBasedCompression")),
        SystemCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemCreationClassName")),
        SystemName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemName")),
        VolumeName = WmiValueConverter.AsString(p.GetValueOrDefault("VolumeName")),
        VolumeSerialNumber = WmiValueConverter.AsString(p.GetValueOrDefault("VolumeSerialNumber")),
    };
}
