using Akira;

namespace Akira.Windows;

/// <summary>
/// WMI provider for <see cref="ComputerSystemSnapshot"/>. Queries Win32_ComputerSystem.
/// </summary>
public sealed class ComputerSystemSnapshotProvider : WmiSnapshotProvider<ComputerSystemSnapshot>
{
    /// <inheritdoc />
    public ComputerSystemSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_ComputerSystem";

    /// <inheritdoc />
    protected override ComputerSystemSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        AdminPasswordStatus = WmiValueConverter.AsUInt16(p.GetValueOrDefault("AdminPasswordStatus")),
        AutomaticManagedPagefile = WmiValueConverter.AsBool(p.GetValueOrDefault("AutomaticManagedPagefile")),
        AutomaticResetBootOption = WmiValueConverter.AsBool(p.GetValueOrDefault("AutomaticResetBootOption")),
        AutomaticResetCapability = WmiValueConverter.AsBool(p.GetValueOrDefault("AutomaticResetCapability")),
        BootOptionOnLimit = WmiValueConverter.AsUInt16(p.GetValueOrDefault("BootOptionOnLimit")),
        BootOptionOnWatchDog = WmiValueConverter.AsUInt16(p.GetValueOrDefault("BootOptionOnWatchDog")),
        BootROMSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("BootROMSupported")),
        BootStatus = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("BootStatus")),
        BootupState = WmiValueConverter.AsString(p.GetValueOrDefault("BootupState")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        ChassisBootupState = WmiValueConverter.AsUInt16(p.GetValueOrDefault("ChassisBootupState")),
        ChassisSKUNumber = WmiValueConverter.AsString(p.GetValueOrDefault("ChassisSKUNumber")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        CurrentTimeZone = WmiValueConverter.AsInt16(p.GetValueOrDefault("CurrentTimeZone")),
        DaylightInEffect = WmiValueConverter.AsBool(p.GetValueOrDefault("DaylightInEffect")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DNSHostName = WmiValueConverter.AsString(p.GetValueOrDefault("DNSHostName")),
        Domain = WmiValueConverter.AsString(p.GetValueOrDefault("Domain")),
        DomainRole = WmiValueConverter.AsUInt16(p.GetValueOrDefault("DomainRole")),
        EnableDaylightSavingsTime = WmiValueConverter.AsBool(p.GetValueOrDefault("EnableDaylightSavingsTime")),
        FrontPanelResetStatus = WmiValueConverter.AsUInt16(p.GetValueOrDefault("FrontPanelResetStatus")),
        HypervisorPresent = WmiValueConverter.AsBool(p.GetValueOrDefault("HypervisorPresent")),
        InfraredSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("InfraredSupported")),
        InitialLoadInfo = WmiValueConverter.AsStringArray(p.GetValueOrDefault("InitialLoadInfo")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        KeyboardPasswordStatus = WmiValueConverter.AsUInt16(p.GetValueOrDefault("KeyboardPasswordStatus")),
        LastLoadInfo = WmiValueConverter.AsString(p.GetValueOrDefault("LastLoadInfo")),
        Manufacturer = WmiValueConverter.AsString(p.GetValueOrDefault("Manufacturer")),
        Model = WmiValueConverter.AsString(p.GetValueOrDefault("Model")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        NameFormat = WmiValueConverter.AsString(p.GetValueOrDefault("NameFormat")),
        NetworkServerModeEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("NetworkServerModeEnabled")),
        NumberOfLogicalProcessors = WmiValueConverter.AsUInt32(p.GetValueOrDefault("NumberOfLogicalProcessors")),
        NumberOfProcessors = WmiValueConverter.AsUInt32(p.GetValueOrDefault("NumberOfProcessors")),
        OEMLogoBitmap = WmiValueConverter.AsByteArray(p.GetValueOrDefault("OEMLogoBitmap")),
        OEMStringArray = WmiValueConverter.AsStringArray(p.GetValueOrDefault("OEMStringArray")),
        PartOfDomain = WmiValueConverter.AsBool(p.GetValueOrDefault("PartOfDomain")),
        PauseAfterReset = WmiValueConverter.AsInt64(p.GetValueOrDefault("PauseAfterReset")),
        PCSystemType = WmiValueConverter.AsUInt16(p.GetValueOrDefault("PCSystemType")),
        PCSystemTypeEx = WmiValueConverter.AsUInt16(p.GetValueOrDefault("PCSystemTypeEx")),
        PowerManagementCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PowerManagementCapabilities")),
        PowerManagementSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("PowerManagementSupported")),
        PowerOnPasswordStatus = WmiValueConverter.AsUInt16(p.GetValueOrDefault("PowerOnPasswordStatus")),
        PowerState = WmiValueConverter.AsUInt16(p.GetValueOrDefault("PowerState")),
        PowerSupplyState = WmiValueConverter.AsUInt16(p.GetValueOrDefault("PowerSupplyState")),
        PrimaryOwnerContact = WmiValueConverter.AsString(p.GetValueOrDefault("PrimaryOwnerContact")),
        PrimaryOwnerName = WmiValueConverter.AsString(p.GetValueOrDefault("PrimaryOwnerName")),
        ResetCapability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("ResetCapability")),
        ResetCount = WmiValueConverter.AsInt16(p.GetValueOrDefault("ResetCount")),
        ResetLimit = WmiValueConverter.AsInt16(p.GetValueOrDefault("ResetLimit")),
        Roles = WmiValueConverter.AsStringArray(p.GetValueOrDefault("Roles")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        SupportContactDescription = WmiValueConverter.AsStringArray(p.GetValueOrDefault("SupportContactDescription")),
        SystemFamily = WmiValueConverter.AsString(p.GetValueOrDefault("SystemFamily")),
        SystemSKUNumber = WmiValueConverter.AsString(p.GetValueOrDefault("SystemSKUNumber")),
        SystemType = WmiValueConverter.AsString(p.GetValueOrDefault("SystemType")),
        ThermalState = WmiValueConverter.AsUInt16(p.GetValueOrDefault("ThermalState")),
        TotalPhysicalMemory = WmiValueConverter.AsUInt64(p.GetValueOrDefault("TotalPhysicalMemory")),
        UserName = WmiValueConverter.AsString(p.GetValueOrDefault("UserName")),
        WakeUpType = WmiValueConverter.AsUInt16(p.GetValueOrDefault("WakeUpType")),
        Workgroup = WmiValueConverter.AsString(p.GetValueOrDefault("Workgroup")),
    };
}
