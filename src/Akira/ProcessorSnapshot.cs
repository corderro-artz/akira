namespace Akira;

/// <summary>
/// Snapshot of a processor. Maps to Win32_Processor.
/// </summary>
public sealed class ProcessorSnapshot
{
    /// <summary>On a 32-bit OS the value is 32; on a 64-bit OS it is 64.</summary>
    public ushort? AddressWidth { get; init; }

    /// <summary>Processor architecture (0 = x86, 9 = x64, 12 = ARM64).</summary>
    public ushort? Architecture { get; init; }

    /// <summary>Asset tag from SMBIOS.</summary>
    public string? AssetTag { get; init; }

    /// <summary>Availability and status of the device.</summary>
    public ushort? Availability { get; init; }

    /// <summary>Short description of the processor.</summary>
    public string? Caption { get; init; }

    /// <summary>SMBIOS Type 4 processor characteristics.</summary>
    public uint? Characteristics { get; init; }

    /// <summary>Win32 Configuration Manager error code.</summary>
    public uint? ConfigManagerErrorCode { get; init; }

    /// <summary>Whether the device is using a user-defined configuration.</summary>
    public bool? ConfigManagerUserConfig { get; init; }

    /// <summary>Current status of the processor (0 = Unknown, 1 = Enabled, etc.).</summary>
    public ushort? CpuStatus { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Current speed of the processor in MHz.</summary>
    public uint? CurrentClockSpeed { get; init; }

    /// <summary>Voltage of the processor in tenths of a volt.</summary>
    public ushort? CurrentVoltage { get; init; }

    /// <summary>Data width of the processor in bits.</summary>
    public ushort? DataWidth { get; init; }

    /// <summary>Description of the processor.</summary>
    public string? Description { get; init; }

    /// <summary>Unique identifier of the processor on the system.</summary>
    public string? DeviceID { get; init; }

    /// <summary>Whether the error reported in LastErrorCode has been cleared.</summary>
    public bool? ErrorCleared { get; init; }

    /// <summary>Free-form string providing more information about the last error.</summary>
    public string? ErrorDescription { get; init; }

    /// <summary>External clock frequency in MHz.</summary>
    public uint? ExtClock { get; init; }

    /// <summary>Processor family type.</summary>
    public ushort? Family { get; init; }

    /// <summary>Date and time the object was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Size of the Level 2 processor cache in KB.</summary>
    public uint? L2CacheSize { get; init; }

    /// <summary>Clock speed of the Level 2 processor cache in MHz.</summary>
    public uint? L2CacheSpeed { get; init; }

    /// <summary>Size of the Level 3 processor cache in KB.</summary>
    public uint? L3CacheSize { get; init; }

    /// <summary>Clock speed of the Level 3 processor cache in MHz.</summary>
    public uint? L3CacheSpeed { get; init; }

    /// <summary>Last error code reported by the logical device.</summary>
    public uint? LastErrorCode { get; init; }

    /// <summary>Definition of the processor type based on CPUID.</summary>
    public ushort? Level { get; init; }

    /// <summary>Load capacity of the processor as a percentage.</summary>
    public ushort? LoadPercentage { get; init; }

    /// <summary>Processor manufacturer.</summary>
    public string? Manufacturer { get; init; }

    /// <summary>Maximum speed of the processor in MHz.</summary>
    public uint? MaxClockSpeed { get; init; }

    /// <summary>Label by which the processor is known.</summary>
    public string? Name { get; init; }

    /// <summary>Number of physical cores for the current processor.</summary>
    public uint? NumberOfCores { get; init; }

    /// <summary>Number of enabled cores per processor socket.</summary>
    public uint? NumberOfEnabledCore { get; init; }

    /// <summary>Number of logical processors for the current processor.</summary>
    public uint? NumberOfLogicalProcessors { get; init; }

    /// <summary>Processor family type when Family is set to 1 (Other).</summary>
    public string? OtherFamilyDescription { get; init; }

    /// <summary>Part number assigned by the manufacturer.</summary>
    public string? PartNumber { get; init; }

    /// <summary>Windows Plug and Play device identifier.</summary>
    public string? PNPDeviceID { get; init; }

    /// <summary>Array of power-related capabilities.</summary>
    public ushort[]? PowerManagementCapabilities { get; init; }

    /// <summary>Whether the device can be power-managed.</summary>
    public bool? PowerManagementSupported { get; init; }

    /// <summary>Processor information describing processor features (x86-specific).</summary>
    public string? ProcessorId { get; init; }

    /// <summary>Primary function of the processor (1 = Other, 3 = Central, etc.).</summary>
    public ushort? ProcessorType { get; init; }

    /// <summary>System-level revision number.</summary>
    public ushort? Revision { get; init; }

    /// <summary>Role of the processor (e.g. "Central Processor").</summary>
    public string? Role { get; init; }

    /// <summary>Whether the processor supports address translation extensions for virtualization.</summary>
    public bool? SecondLevelAddressTranslationExtensions { get; init; }

    /// <summary>Processor serial number from SMBIOS.</summary>
    public string? SerialNumber { get; init; }

    /// <summary>Type of chip socket used (e.g. "Socket AM5", "LGA1700").</summary>
    public string? SocketDesignation { get; init; }

    /// <summary>Current status of the processor ("OK", "Error", etc.).</summary>
    public string? Status { get; init; }

    /// <summary>State of the logical device (1 = Other, 3 = Enabled, 4 = Disabled).</summary>
    public ushort? StatusInfo { get; init; }

    /// <summary>Revision level of the processor in the processor family.</summary>
    public string? Stepping { get; init; }

    /// <summary>CreationClassName of the scoping computer system.</summary>
    public string? SystemCreationClassName { get; init; }

    /// <summary>Name of the scoping system.</summary>
    public string? SystemName { get; init; }

    /// <summary>Number of threads per processor socket.</summary>
    public uint? ThreadCount { get; init; }

    /// <summary>Globally unique identifier for the processor.</summary>
    public string? UniqueId { get; init; }

    /// <summary>CPU socket upgrade method (1 = Other, 2 = Unknown, 3 = Daughter Board, etc.).</summary>
    public ushort? UpgradeMethod { get; init; }

    /// <summary>Processor revision number (e.g. "Model 2, Stepping 12").</summary>
    public string? Version { get; init; }

    /// <summary>Whether firmware-enabled virtualization is active.</summary>
    public bool? VirtualizationFirmwareEnabled { get; init; }

    /// <summary>Whether the processor supports Intel VT-x or AMD-V extensions.</summary>
    public bool? VMMonitorModeExtensions { get; init; }

    /// <summary>Voltage capabilities of the processor (bit field).</summary>
    public uint? VoltageCaps { get; init; }
}
