using Akira;

namespace Akira.Windows;

/// <summary>
/// WMI provider for <see cref="VideoControllerSnapshot"/>. Queries Win32_VideoController.
/// </summary>
public sealed class VideoControllerSnapshotProvider : WmiCollectionSnapshotProvider<VideoControllerSnapshot>
{
    /// <inheritdoc />
    public VideoControllerSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_VideoController";

    /// <inheritdoc />
    protected override VideoControllerSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        AcceleratorCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("AcceleratorCapabilities")),
        AdapterCompatibility = WmiValueConverter.AsString(p.GetValueOrDefault("AdapterCompatibility")),
        AdapterDACType = WmiValueConverter.AsString(p.GetValueOrDefault("AdapterDACType")),
        AdapterRAM = WmiValueConverter.AsUInt32(p.GetValueOrDefault("AdapterRAM")),
        Availability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Availability")),
        CapabilityDescriptions = WmiValueConverter.AsStringArray(p.GetValueOrDefault("CapabilityDescriptions")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        ColorTableEntries = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ColorTableEntries")),
        ConfigManagerErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfigManagerErrorCode")),
        ConfigManagerUserConfig = WmiValueConverter.AsBool(p.GetValueOrDefault("ConfigManagerUserConfig")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        CurrentBitsPerPixel = WmiValueConverter.AsUInt32(p.GetValueOrDefault("CurrentBitsPerPixel")),
        CurrentHorizontalResolution = WmiValueConverter.AsUInt32(p.GetValueOrDefault("CurrentHorizontalResolution")),
        CurrentNumberOfColors = WmiValueConverter.AsUInt64(p.GetValueOrDefault("CurrentNumberOfColors")),
        CurrentNumberOfColumns = WmiValueConverter.AsUInt32(p.GetValueOrDefault("CurrentNumberOfColumns")),
        CurrentNumberOfRows = WmiValueConverter.AsUInt32(p.GetValueOrDefault("CurrentNumberOfRows")),
        CurrentRefreshRate = WmiValueConverter.AsUInt32(p.GetValueOrDefault("CurrentRefreshRate")),
        CurrentScanMode = WmiValueConverter.AsUInt16(p.GetValueOrDefault("CurrentScanMode")),
        CurrentVerticalResolution = WmiValueConverter.AsUInt32(p.GetValueOrDefault("CurrentVerticalResolution")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("DeviceID")),
        DeviceSpecificPens = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DeviceSpecificPens")),
        DitherType = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DitherType")),
        DriverDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("DriverDate")),
        DriverVersion = WmiValueConverter.AsString(p.GetValueOrDefault("DriverVersion")),
        ErrorCleared = WmiValueConverter.AsBool(p.GetValueOrDefault("ErrorCleared")),
        ErrorDescription = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorDescription")),
        ICMIntent = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ICMIntent")),
        ICMMethod = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ICMMethod")),
        InfFilename = WmiValueConverter.AsString(p.GetValueOrDefault("InfFilename")),
        InfSection = WmiValueConverter.AsString(p.GetValueOrDefault("InfSection")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        InstalledDisplayDrivers = WmiValueConverter.AsString(p.GetValueOrDefault("InstalledDisplayDrivers")),
        LastErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("LastErrorCode")),
        MaxMemorySupported = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaxMemorySupported")),
        MaxNumberControlled = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaxNumberControlled")),
        MaxRefreshRate = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaxRefreshRate")),
        MinRefreshRate = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MinRefreshRate")),
        Monochrome = WmiValueConverter.AsBool(p.GetValueOrDefault("Monochrome")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        NumberOfColorPlanes = WmiValueConverter.AsUInt16(p.GetValueOrDefault("NumberOfColorPlanes")),
        NumberOfVideoPages = WmiValueConverter.AsUInt32(p.GetValueOrDefault("NumberOfVideoPages")),
        PNPDeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("PNPDeviceID")),
        PowerManagementCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PowerManagementCapabilities")),
        PowerManagementSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("PowerManagementSupported")),
        ProtocolSupported = WmiValueConverter.AsUInt16(p.GetValueOrDefault("ProtocolSupported")),
        ReservedSystemPaletteEntries = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ReservedSystemPaletteEntries")),
        SpecificationVersion = WmiValueConverter.AsUInt32(p.GetValueOrDefault("SpecificationVersion")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        StatusInfo = WmiValueConverter.AsUInt16(p.GetValueOrDefault("StatusInfo")),
        SystemCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemCreationClassName")),
        SystemName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemName")),
        SystemPaletteEntries = WmiValueConverter.AsUInt32(p.GetValueOrDefault("SystemPaletteEntries")),
        TimeOfLastReset = WmiValueConverter.AsDateTime(p.GetValueOrDefault("TimeOfLastReset")),
        VideoArchitecture = WmiValueConverter.AsUInt16(p.GetValueOrDefault("VideoArchitecture")),
        VideoMemoryType = WmiValueConverter.AsUInt16(p.GetValueOrDefault("VideoMemoryType")),
        VideoMode = WmiValueConverter.AsUInt16(p.GetValueOrDefault("VideoMode")),
        VideoModeDescription = WmiValueConverter.AsString(p.GetValueOrDefault("VideoModeDescription")),
        VideoProcessor = WmiValueConverter.AsString(p.GetValueOrDefault("VideoProcessor")),
    };
}
