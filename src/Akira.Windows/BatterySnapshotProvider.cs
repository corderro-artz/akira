using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="BatterySnapshot"/>. Queries Win32_Battery.
/// </summary>
public sealed class BatterySnapshotProvider : WmiCollectionSnapshotProvider<BatterySnapshot>
{
    /// <inheritdoc />
    public BatterySnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_Battery";

    /// <inheritdoc />
    protected override BatterySnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Availability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Availability")),
        BatteryStatus = WmiValueConverter.AsUInt16(p.GetValueOrDefault("BatteryStatus")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        Chemistry = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Chemistry")),
        ConfigManagerErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfigManagerErrorCode")),
        ConfigManagerUserConfig = WmiValueConverter.AsBool(p.GetValueOrDefault("ConfigManagerUserConfig")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DesignCapacity = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DesignCapacity")),
        DesignVoltage = WmiValueConverter.AsUInt64(p.GetValueOrDefault("DesignVoltage")),
        DeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("DeviceID")),
        ErrorCleared = WmiValueConverter.AsBool(p.GetValueOrDefault("ErrorCleared")),
        ErrorDescription = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorDescription")),
        EstimatedChargeRemaining = WmiValueConverter.AsUInt16(p.GetValueOrDefault("EstimatedChargeRemaining")),
        EstimatedRunTime = WmiValueConverter.AsUInt32(p.GetValueOrDefault("EstimatedRunTime")),
        ExpectedLife = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ExpectedLife")),
        FullChargeCapacity = WmiValueConverter.AsUInt32(p.GetValueOrDefault("FullChargeCapacity")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        LastErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("LastErrorCode")),
        MaxRechargeTime = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaxRechargeTime")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        PNPDeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("PNPDeviceID")),
        PowerManagementCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PowerManagementCapabilities")),
        PowerManagementSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("PowerManagementSupported")),
        SmartBatteryVersion = WmiValueConverter.AsString(p.GetValueOrDefault("SmartBatteryVersion")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        StatusInfo = WmiValueConverter.AsUInt16(p.GetValueOrDefault("StatusInfo")),
        SystemCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemCreationClassName")),
        SystemName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemName")),
        TimeOnBattery = WmiValueConverter.AsUInt32(p.GetValueOrDefault("TimeOnBattery")),
        TimeToFullCharge = WmiValueConverter.AsUInt32(p.GetValueOrDefault("TimeToFullCharge")),
    };
}
