using Akira;

namespace Akira.Windows;

/// <summary>
/// WMI provider for <see cref="ProcessorSnapshot"/>. Queries Win32_Processor.
/// </summary>
public sealed class ProcessorSnapshotProvider : WmiCollectionSnapshotProvider<ProcessorSnapshot>
{
    /// <inheritdoc />
    public ProcessorSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_Processor";

    /// <inheritdoc />
    protected override ProcessorSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        AddressWidth = WmiValueConverter.AsUInt16(p.GetValueOrDefault("AddressWidth")),
        Architecture = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Architecture")),
        AssetTag = WmiValueConverter.AsString(p.GetValueOrDefault("AssetTag")),
        Availability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Availability")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        Characteristics = WmiValueConverter.AsUInt32(p.GetValueOrDefault("Characteristics")),
        ConfigManagerErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfigManagerErrorCode")),
        ConfigManagerUserConfig = WmiValueConverter.AsBool(p.GetValueOrDefault("ConfigManagerUserConfig")),
        CpuStatus = WmiValueConverter.AsUInt16(p.GetValueOrDefault("CpuStatus")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        CurrentClockSpeed = WmiValueConverter.AsUInt32(p.GetValueOrDefault("CurrentClockSpeed")),
        CurrentVoltage = WmiValueConverter.AsUInt16(p.GetValueOrDefault("CurrentVoltage")),
        DataWidth = WmiValueConverter.AsUInt16(p.GetValueOrDefault("DataWidth")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("DeviceID")),
        ErrorCleared = WmiValueConverter.AsBool(p.GetValueOrDefault("ErrorCleared")),
        ErrorDescription = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorDescription")),
        ExtClock = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ExtClock")),
        Family = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Family")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        L2CacheSize = WmiValueConverter.AsUInt32(p.GetValueOrDefault("L2CacheSize")),
        L2CacheSpeed = WmiValueConverter.AsUInt32(p.GetValueOrDefault("L2CacheSpeed")),
        L3CacheSize = WmiValueConverter.AsUInt32(p.GetValueOrDefault("L3CacheSize")),
        L3CacheSpeed = WmiValueConverter.AsUInt32(p.GetValueOrDefault("L3CacheSpeed")),
        LastErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("LastErrorCode")),
        Level = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Level")),
        LoadPercentage = WmiValueConverter.AsUInt16(p.GetValueOrDefault("LoadPercentage")),
        Manufacturer = WmiValueConverter.AsString(p.GetValueOrDefault("Manufacturer")),
        MaxClockSpeed = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaxClockSpeed")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        NumberOfCores = WmiValueConverter.AsUInt32(p.GetValueOrDefault("NumberOfCores")),
        NumberOfEnabledCore = WmiValueConverter.AsUInt32(p.GetValueOrDefault("NumberOfEnabledCore")),
        NumberOfLogicalProcessors = WmiValueConverter.AsUInt32(p.GetValueOrDefault("NumberOfLogicalProcessors")),
        OtherFamilyDescription = WmiValueConverter.AsString(p.GetValueOrDefault("OtherFamilyDescription")),
        PartNumber = WmiValueConverter.AsString(p.GetValueOrDefault("PartNumber")),
        PNPDeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("PNPDeviceID")),
        PowerManagementCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PowerManagementCapabilities")),
        PowerManagementSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("PowerManagementSupported")),
        ProcessorId = WmiValueConverter.AsString(p.GetValueOrDefault("ProcessorId")),
        ProcessorType = WmiValueConverter.AsUInt16(p.GetValueOrDefault("ProcessorType")),
        Revision = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Revision")),
        Role = WmiValueConverter.AsString(p.GetValueOrDefault("Role")),
        SecondLevelAddressTranslationExtensions = WmiValueConverter.AsBool(p.GetValueOrDefault("SecondLevelAddressTranslationExtensions")),
        SerialNumber = WmiValueConverter.AsString(p.GetValueOrDefault("SerialNumber")),
        SocketDesignation = WmiValueConverter.AsString(p.GetValueOrDefault("SocketDesignation")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        StatusInfo = WmiValueConverter.AsUInt16(p.GetValueOrDefault("StatusInfo")),
        Stepping = WmiValueConverter.AsString(p.GetValueOrDefault("Stepping")),
        SystemCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemCreationClassName")),
        SystemName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemName")),
        ThreadCount = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ThreadCount")),
        UniqueId = WmiValueConverter.AsString(p.GetValueOrDefault("UniqueId")),
        UpgradeMethod = WmiValueConverter.AsUInt16(p.GetValueOrDefault("UpgradeMethod")),
        Version = WmiValueConverter.AsString(p.GetValueOrDefault("Version")),
        VirtualizationFirmwareEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("VirtualizationFirmwareEnabled")),
        VMMonitorModeExtensions = WmiValueConverter.AsBool(p.GetValueOrDefault("VMMonitorModeExtensions")),
        VoltageCaps = WmiValueConverter.AsUInt32(p.GetValueOrDefault("VoltageCaps")),
    };
}
