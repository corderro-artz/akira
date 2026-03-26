namespace Akira;

/// <summary>
/// Snapshot of the computer system. Maps to Win32_ComputerSystem.
/// </summary>
public sealed class ComputerSystemSnapshot
{
    /// <summary>Hardware security setting for the administrator password (0 = Disabled, 1 = Enabled, etc.).</summary>
    public ushort? AdminPasswordStatus { get; init; }

    /// <summary>Whether the pagefile is automatically managed.</summary>
    public bool? AutomaticManagedPagefile { get; init; }

    /// <summary>Whether the automatic reset boot option is enabled.</summary>
    public bool? AutomaticResetBootOption { get; init; }

    /// <summary>Whether the automatic reset is enabled.</summary>
    public bool? AutomaticResetCapability { get; init; }

    /// <summary>System action to take when the boot count limit is reached.</summary>
    public ushort? BootOptionOnLimit { get; init; }

    /// <summary>System action to take when the watchdog timer reaches the limit.</summary>
    public ushort? BootOptionOnWatchDog { get; init; }

    /// <summary>Whether a boot ROM is supported.</summary>
    public bool? BootROMSupported { get; init; }

    /// <summary>Array of boot status values from the last system boot.</summary>
    public ushort[]? BootStatus { get; init; }

    /// <summary>Status of the system at the last boot (e.g. "Normal boot").</summary>
    public string? BootupState { get; init; }

    /// <summary>Short description of the computer system.</summary>
    public string? Caption { get; init; }

    /// <summary>Bootup state of the system chassis.</summary>
    public ushort? ChassisBootupState { get; init; }

    /// <summary>Chassis SKU number.</summary>
    public string? ChassisSKUNumber { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Amount of time the unitary computer system is offset from UTC.</summary>
    public short? CurrentTimeZone { get; init; }

    /// <summary>Whether daylight saving time is currently in effect.</summary>
    public bool? DaylightInEffect { get; init; }

    /// <summary>Description of the computer system.</summary>
    public string? Description { get; init; }

    /// <summary>DNS host name of the local computer.</summary>
    public string? DNSHostName { get; init; }

    /// <summary>Name of the domain to which the computer belongs.</summary>
    public string? Domain { get; init; }

    /// <summary>Role of the computer in the domain (0 = Standalone Workstation, 5 = Primary Domain Controller, etc.).</summary>
    public ushort? DomainRole { get; init; }

    /// <summary>Whether daylight savings mode is enabled.</summary>
    public bool? EnableDaylightSavingsTime { get; init; }

    /// <summary>Hardware security setting for the front panel reset button.</summary>
    public ushort? FrontPanelResetStatus { get; init; }

    /// <summary>Whether a hypervisor is present.</summary>
    public bool? HypervisorPresent { get; init; }

    /// <summary>Whether an infrared (IR) port is available on the system.</summary>
    public bool? InfraredSupported { get; init; }

    /// <summary>Data needed to find an initial load device or boot service.</summary>
    public string[]? InitialLoadInfo { get; init; }

    /// <summary>Date and time the computer system was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Hardware security setting for the keyboard password.</summary>
    public ushort? KeyboardPasswordStatus { get; init; }

    /// <summary>Data for the last attempted load of the operating system.</summary>
    public string? LastLoadInfo { get; init; }

    /// <summary>Manufacturer of the computer system.</summary>
    public string? Manufacturer { get; init; }

    /// <summary>Product name of the computer system.</summary>
    public string? Model { get; init; }

    /// <summary>Name of the computer system.</summary>
    public string? Name { get; init; }

    /// <summary>Identifies how the computer system name is generated.</summary>
    public string? NameFormat { get; init; }

    /// <summary>Whether network server mode is enabled.</summary>
    public bool? NetworkServerModeEnabled { get; init; }

    /// <summary>Number of logical processors available on the computer.</summary>
    public uint? NumberOfLogicalProcessors { get; init; }

    /// <summary>Number of physical processors currently installed.</summary>
    public uint? NumberOfProcessors { get; init; }

    /// <summary>OEM logo bitmap data.</summary>
    public byte[]? OEMLogoBitmap { get; init; }

    /// <summary>Array of free-form OEM-defined strings.</summary>
    public string[]? OEMStringArray { get; init; }

    /// <summary>Whether the computer is part of a domain (true) or workgroup (false).</summary>
    public bool? PartOfDomain { get; init; }

    /// <summary>Time delay in milliseconds before a reboot is initiated after a system power cycle.</summary>
    public long? PauseAfterReset { get; init; }

    /// <summary>Type of PC (e.g. 1 = Desktop, 2 = Mobile, etc.).</summary>
    public ushort? PCSystemType { get; init; }

    /// <summary>Extended PC type (e.g. 1 = Desktop, 8 = Tablet, 14 = Max).</summary>
    public ushort? PCSystemTypeEx { get; init; }

    /// <summary>Array of the specific power-related capabilities of the system.</summary>
    public ushort[]? PowerManagementCapabilities { get; init; }

    /// <summary>Whether the device supports power management.</summary>
    public bool? PowerManagementSupported { get; init; }

    /// <summary>Hardware security setting for the power-on password.</summary>
    public ushort? PowerOnPasswordStatus { get; init; }

    /// <summary>Current power state of the computer.</summary>
    public ushort? PowerState { get; init; }

    /// <summary>State of the power supply or supplies when last booted.</summary>
    public ushort? PowerSupplyState { get; init; }

    /// <summary>Contact information for the primary system owner.</summary>
    public string? PrimaryOwnerContact { get; init; }

    /// <summary>Name of the primary system owner.</summary>
    public string? PrimaryOwnerName { get; init; }

    /// <summary>Whether the computer can be reset (1 = Other, 2 = Unknown, etc.).</summary>
    public ushort? ResetCapability { get; init; }

    /// <summary>Number of automatic resets since the last intentional reset.</summary>
    public short? ResetCount { get; init; }

    /// <summary>Number of consecutive times a system reset is attempted.</summary>
    public short? ResetLimit { get; init; }

    /// <summary>Array of the system roles (e.g. "LM_Workstation", "LM_Server").</summary>
    public string[]? Roles { get; init; }

    /// <summary>Current status of the computer system.</summary>
    public string? Status { get; init; }

    /// <summary>Array of the support contact descriptions.</summary>
    public string[]? SupportContactDescription { get; init; }

    /// <summary>Family the computer belongs to, set by the manufacturer.</summary>
    public string? SystemFamily { get; init; }

    /// <summary>System SKU number.</summary>
    public string? SystemSKUNumber { get; init; }

    /// <summary>System architecture type (e.g. "x64-based PC").</summary>
    public string? SystemType { get; init; }

    /// <summary>Thermal state of the system when last booted.</summary>
    public ushort? ThermalState { get; init; }

    /// <summary>Total amount of physical memory available to the OS in bytes.</summary>
    public ulong? TotalPhysicalMemory { get; init; }

    /// <summary>Name of the currently logged-on user (DOMAIN\username).</summary>
    public string? UserName { get; init; }

    /// <summary>Event that caused the system to power up.</summary>
    public ushort? WakeUpType { get; init; }

    /// <summary>Name of the workgroup (if the computer is not part of a domain).</summary>
    public string? Workgroup { get; init; }
}
