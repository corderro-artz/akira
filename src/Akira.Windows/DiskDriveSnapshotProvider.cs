using Akira;

namespace Akira.Windows;

/// <summary>
/// WMI provider for <see cref="DiskDriveSnapshot"/>. Queries Win32_DiskDrive.
/// </summary>
public sealed class DiskDriveSnapshotProvider : WmiCollectionSnapshotProvider<DiskDriveSnapshot>
{
    /// <inheritdoc />
    public DiskDriveSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_DiskDrive";

    /// <inheritdoc />
    protected override DiskDriveSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Availability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Availability")),
        BytesPerSector = WmiValueConverter.AsUInt32(p.GetValueOrDefault("BytesPerSector")),
        Capabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("Capabilities")),
        CapabilityDescriptions = WmiValueConverter.AsStringArray(p.GetValueOrDefault("CapabilityDescriptions")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        CompressionMethod = WmiValueConverter.AsString(p.GetValueOrDefault("CompressionMethod")),
        ConfigManagerErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfigManagerErrorCode")),
        ConfigManagerUserConfig = WmiValueConverter.AsBool(p.GetValueOrDefault("ConfigManagerUserConfig")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        DefaultBlockSize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("DefaultBlockSize")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("DeviceID")),
        ErrorCleared = WmiValueConverter.AsBool(p.GetValueOrDefault("ErrorCleared")),
        ErrorDescription = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorDescription")),
        ErrorMethodology = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorMethodology")),
        FirmwareRevision = WmiValueConverter.AsString(p.GetValueOrDefault("FirmwareRevision")),
        Index = WmiValueConverter.AsUInt32(p.GetValueOrDefault("Index")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        InterfaceType = WmiValueConverter.AsString(p.GetValueOrDefault("InterfaceType")),
        LastErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("LastErrorCode")),
        Manufacturer = WmiValueConverter.AsString(p.GetValueOrDefault("Manufacturer")),
        MaxBlockSize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("MaxBlockSize")),
        MaxMediaSize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("MaxMediaSize")),
        MediaLoaded = WmiValueConverter.AsBool(p.GetValueOrDefault("MediaLoaded")),
        MediaType = WmiValueConverter.AsString(p.GetValueOrDefault("MediaType")),
        MinBlockSize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("MinBlockSize")),
        Model = WmiValueConverter.AsString(p.GetValueOrDefault("Model")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        NeedsCleaning = WmiValueConverter.AsBool(p.GetValueOrDefault("NeedsCleaning")),
        NumberOfMediaSupported = WmiValueConverter.AsUInt32(p.GetValueOrDefault("NumberOfMediaSupported")),
        Partitions = WmiValueConverter.AsUInt32(p.GetValueOrDefault("Partitions")),
        PNPDeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("PNPDeviceID")),
        PowerManagementCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PowerManagementCapabilities")),
        PowerManagementSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("PowerManagementSupported")),
        SCSIBus = WmiValueConverter.AsUInt32(p.GetValueOrDefault("SCSIBus")),
        SCSILogicalUnit = WmiValueConverter.AsUInt16(p.GetValueOrDefault("SCSILogicalUnit")),
        SCSIPort = WmiValueConverter.AsUInt16(p.GetValueOrDefault("SCSIPort")),
        SCSITargetId = WmiValueConverter.AsUInt16(p.GetValueOrDefault("SCSITargetId")),
        SectorsPerTrack = WmiValueConverter.AsUInt32(p.GetValueOrDefault("SectorsPerTrack")),
        SerialNumber = WmiValueConverter.AsString(p.GetValueOrDefault("SerialNumber")),
        Signature = WmiValueConverter.AsUInt32(p.GetValueOrDefault("Signature")),
        Size = WmiValueConverter.AsUInt64(p.GetValueOrDefault("Size")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        StatusInfo = WmiValueConverter.AsUInt16(p.GetValueOrDefault("StatusInfo")),
        SystemCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemCreationClassName")),
        SystemName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemName")),
        TotalCylinders = WmiValueConverter.AsUInt64(p.GetValueOrDefault("TotalCylinders")),
        TotalHeads = WmiValueConverter.AsUInt32(p.GetValueOrDefault("TotalHeads")),
        TotalSectors = WmiValueConverter.AsUInt64(p.GetValueOrDefault("TotalSectors")),
        TotalTracks = WmiValueConverter.AsUInt64(p.GetValueOrDefault("TotalTracks")),
        TracksPerCylinder = WmiValueConverter.AsUInt32(p.GetValueOrDefault("TracksPerCylinder")),
    };
}
