using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="DesktopMonitorSnapshot"/>. Queries Win32_DesktopMonitor.
/// </summary>
public sealed class DesktopMonitorSnapshotProvider : WmiCollectionSnapshotProvider<DesktopMonitorSnapshot>
{
    /// <inheritdoc />
    public DesktopMonitorSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_DesktopMonitor";

    /// <inheritdoc />
    protected override DesktopMonitorSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Availability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Availability")),
        Bandwidth = WmiValueConverter.AsUInt32(p.GetValueOrDefault("Bandwidth")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        ConfigManagerErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfigManagerErrorCode")),
        ConfigManagerUserConfig = WmiValueConverter.AsBool(p.GetValueOrDefault("ConfigManagerUserConfig")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("DeviceID")),
        DisplayType = WmiValueConverter.AsUInt16(p.GetValueOrDefault("DisplayType")),
        ErrorCleared = WmiValueConverter.AsBool(p.GetValueOrDefault("ErrorCleared")),
        ErrorDescription = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorDescription")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        IsLocked = WmiValueConverter.AsBool(p.GetValueOrDefault("IsLocked")),
        LastErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("LastErrorCode")),
        MonitorManufacturer = WmiValueConverter.AsString(p.GetValueOrDefault("MonitorManufacturer")),
        MonitorType = WmiValueConverter.AsString(p.GetValueOrDefault("MonitorType")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        PixelsPerXLogicalInch = WmiValueConverter.AsUInt32(p.GetValueOrDefault("PixelsPerXLogicalInch")),
        PixelsPerYLogicalInch = WmiValueConverter.AsUInt32(p.GetValueOrDefault("PixelsPerYLogicalInch")),
        PNPDeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("PNPDeviceID")),
        PowerManagementCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PowerManagementCapabilities")),
        PowerManagementSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("PowerManagementSupported")),
        ScreenHeight = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ScreenHeight")),
        ScreenWidth = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ScreenWidth")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        StatusInfo = WmiValueConverter.AsUInt16(p.GetValueOrDefault("StatusInfo")),
        SystemCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemCreationClassName")),
        SystemName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemName")),
    };
}
