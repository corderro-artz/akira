using Akira;

namespace Akira.Windows;

/// <summary>
/// WMI provider for <see cref="FanSnapshot"/>. Queries Win32_Fan.
/// </summary>
public sealed class FanSnapshotProvider : WmiCollectionSnapshotProvider<FanSnapshot>
{
    /// <inheritdoc />
    public FanSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_Fan";

    /// <inheritdoc />
    protected override FanSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        ActiveCooling = WmiValueConverter.AsBool(p.GetValueOrDefault("ActiveCooling")),
        Availability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Availability")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        ConfigManagerErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfigManagerErrorCode")),
        ConfigManagerUserConfig = WmiValueConverter.AsBool(p.GetValueOrDefault("ConfigManagerUserConfig")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DesiredSpeed = WmiValueConverter.AsUInt64(p.GetValueOrDefault("DesiredSpeed")),
        DeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("DeviceID")),
        ErrorCleared = WmiValueConverter.AsBool(p.GetValueOrDefault("ErrorCleared")),
        ErrorDescription = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorDescription")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        LastErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("LastErrorCode")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        PNPDeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("PNPDeviceID")),
        PowerManagementCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PowerManagementCapabilities")),
        PowerManagementSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("PowerManagementSupported")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        StatusInfo = WmiValueConverter.AsUInt16(p.GetValueOrDefault("StatusInfo")),
        SystemCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemCreationClassName")),
        SystemName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemName")),
        VariableSpeed = WmiValueConverter.AsBool(p.GetValueOrDefault("VariableSpeed")),
    };
}
