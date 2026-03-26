using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="SoundDeviceSnapshot"/>. Queries Win32_SoundDevice.
/// </summary>
public sealed class SoundDeviceSnapshotProvider : WmiCollectionSnapshotProvider<SoundDeviceSnapshot>
{
    /// <inheritdoc />
    public SoundDeviceSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_SoundDevice";

    /// <inheritdoc />
    protected override SoundDeviceSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Availability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Availability")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        ConfigManagerErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfigManagerErrorCode")),
        ConfigManagerUserConfig = WmiValueConverter.AsBool(p.GetValueOrDefault("ConfigManagerUserConfig")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("DeviceID")),
        DMABufferSize = WmiValueConverter.AsUInt16(p.GetValueOrDefault("DMABufferSize")),
        ErrorCleared = WmiValueConverter.AsBool(p.GetValueOrDefault("ErrorCleared")),
        ErrorDescription = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorDescription")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        LastErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("LastErrorCode")),
        Manufacturer = WmiValueConverter.AsString(p.GetValueOrDefault("Manufacturer")),
        MPU401Address = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MPU401Address")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        PNPDeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("PNPDeviceID")),
        PowerManagementCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PowerManagementCapabilities")),
        PowerManagementSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("PowerManagementSupported")),
        ProductName = WmiValueConverter.AsString(p.GetValueOrDefault("ProductName")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        StatusInfo = WmiValueConverter.AsUInt16(p.GetValueOrDefault("StatusInfo")),
        SystemCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemCreationClassName")),
        SystemName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemName")),
    };
}
