namespace Vaporsoft.Akira;

/// <summary>
/// Snapshot of the operating system. Maps to Win32_OperatingSystem.
/// </summary>
public sealed class OperatingSystemSnapshot
{
    /// <summary>Name of the boot disk drive.</summary>
    public string? BootDevice { get; init; }

    /// <summary>Build number of the operating system.</summary>
    public string? BuildNumber { get; init; }

    /// <summary>Type of build ("retail build", "checked build").</summary>
    public string? BuildType { get; init; }

    /// <summary>Short description including the OS version.</summary>
    public string? Caption { get; init; }

    /// <summary>ANSI code page value.</summary>
    public string? CodeSet { get; init; }

    /// <summary>Country/region code based on international phone dialing prefixes.</summary>
    public string? CountryCode { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>CreationClassName of the scoping computer system.</summary>
    public string? CSCreationClassName { get; init; }

    /// <summary>Latest service pack installed, or null if none.</summary>
    public string? CSDVersion { get; init; }

    /// <summary>Name of the scoping computer system.</summary>
    public string? CSName { get; init; }

    /// <summary>Number of minutes the OS is offset from GMT.</summary>
    public short? CurrentTimeZone { get; init; }

    /// <summary>Whether DEP hardware feature is available.</summary>
    public bool? DataExecutionPrevention_Available { get; init; }

    /// <summary>Whether DEP is set to work for 32-bit applications.</summary>
    public bool? DataExecutionPrevention_32BitApplications { get; init; }

    /// <summary>Whether DEP is set to work for drivers.</summary>
    public bool? DataExecutionPrevention_Drivers { get; init; }

    /// <summary>DEP support policy (0 = Always Off, 1 = Always On, 2 = Opt In, 3 = Opt Out).</summary>
    public byte? DataExecutionPrevention_SupportPolicy { get; init; }

    /// <summary>Whether this is a debug/checked build.</summary>
    public bool? Debug { get; init; }

    /// <summary>Description of the operating system.</summary>
    public string? Description { get; init; }

    /// <summary>Whether the OS is distributed across several nodes.</summary>
    public bool? Distributed { get; init; }

    /// <summary>Encryption level for secure transactions (0 = 40-bit, 1 = 128-bit, 2 = n-bit).</summary>
    public uint? EncryptionLevel { get; init; }

    /// <summary>Priority boost given to the foreground application (0 = None, 1 = Minimum, 2 = Maximum).</summary>
    public byte? ForegroundApplicationBoost { get; init; }

    /// <summary>Amount of physical memory currently unused, in KB.</summary>
    public ulong? FreePhysicalMemory { get; init; }

    /// <summary>Space available in the paging files, in KB.</summary>
    public ulong? FreeSpaceInPagingFiles { get; init; }

    /// <summary>Virtual memory currently unused, in KB.</summary>
    public ulong? FreeVirtualMemory { get; init; }

    /// <summary>Date and time the OS was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Deprecated; system cache memory optimization setting.</summary>
    public uint? LargeSystemCache { get; init; }

    /// <summary>Date and time the OS was last restarted.</summary>
    public DateTime? LastBootUpTime { get; init; }

    /// <summary>Local date and time of day on the operating system.</summary>
    public DateTime? LocalDateTime { get; init; }

    /// <summary>Language identifier (LANGID) used by the OS.</summary>
    public string? Locale { get; init; }

    /// <summary>Name of the operating system manufacturer.</summary>
    public string? Manufacturer { get; init; }

    /// <summary>Maximum number of process contexts the OS can support.</summary>
    public uint? MaxNumberOfProcesses { get; init; }

    /// <summary>Maximum memory that can be allocated to a process, in KB.</summary>
    public ulong? MaxProcessMemorySize { get; init; }

    /// <summary>Array of MUI Pack languages installed.</summary>
    public string[]? MUILanguages { get; init; }

    /// <summary>Operating system instance name within a computer system.</summary>
    public string? Name { get; init; }

    /// <summary>Number of user licenses for the OS.</summary>
    public uint? NumberOfLicensedUsers { get; init; }

    /// <summary>Number of process contexts currently loaded or running.</summary>
    public uint? NumberOfProcesses { get; init; }

    /// <summary>Number of user sessions for which the OS is storing state.</summary>
    public uint? NumberOfUsers { get; init; }

    /// <summary>Stock Keeping Unit (SKU) number for the operating system.</summary>
    public uint? OperatingSystemSKU { get; init; }

    /// <summary>Registered organization name.</summary>
    public string? Organization { get; init; }

    /// <summary>Architecture of the operating system (e.g. "64-bit").</summary>
    public string? OSArchitecture { get; init; }

    /// <summary>Language version of the operating system.</summary>
    public uint? OSLanguage { get; init; }

    /// <summary>Installed and licensed system product additions (bit flags).</summary>
    public uint? OSProductSuite { get; init; }

    /// <summary>Type of operating system.</summary>
    public ushort? OSType { get; init; }

    /// <summary>Additional description for the current OS version.</summary>
    public string? OtherTypeDescription { get; init; }

    /// <summary>Whether Physical Address Extensions (PAE) are enabled.</summary>
    public bool? PAEEnabled { get; init; }

    /// <summary>Not supported. Plus! product identifier.</summary>
    public string? PlusProductID { get; init; }

    /// <summary>Not supported. Plus! version number.</summary>
    public string? PlusVersionNumber { get; init; }

    /// <summary>Whether the OS booted from an external USB device.</summary>
    public bool? PortableOperatingSystem { get; init; }

    /// <summary>Whether this is the primary operating system.</summary>
    public bool? Primary { get; init; }

    /// <summary>Additional system information (1 = Workstation, 2 = Domain Controller, 3 = Server).</summary>
    public uint? ProductType { get; init; }

    /// <summary>Not supported. Quantum length setting.</summary>
    public byte? QuantumLength { get; init; }

    /// <summary>Not supported. Quantum type setting.</summary>
    public byte? QuantumType { get; init; }

    /// <summary>Name of the registered user of the operating system.</summary>
    public string? RegisteredUser { get; init; }

    /// <summary>Operating system product serial identification number.</summary>
    public string? SerialNumber { get; init; }

    /// <summary>Major version number of the installed service pack.</summary>
    public ushort? ServicePackMajorVersion { get; init; }

    /// <summary>Minor version number of the installed service pack.</summary>
    public ushort? ServicePackMinorVersion { get; init; }

    /// <summary>Total number of KB that can be stored in the paging files.</summary>
    public ulong? SizeStoredInPagingFiles { get; init; }

    /// <summary>Current status of the object.</summary>
    public string? Status { get; init; }

    /// <summary>Bit flags identifying the product suites available on the system.</summary>
    public uint? SuiteMask { get; init; }

    /// <summary>Physical disk partition on which the OS is installed.</summary>
    public string? SystemDevice { get; init; }

    /// <summary>System directory of the operating system.</summary>
    public string? SystemDirectory { get; init; }

    /// <summary>Letter of the disk drive on which the OS resides.</summary>
    public string? SystemDrive { get; init; }

    /// <summary>Total swap space in KB.</summary>
    public ulong? TotalSwapSpaceSize { get; init; }

    /// <summary>Total virtual memory in KB.</summary>
    public ulong? TotalVirtualMemorySize { get; init; }

    /// <summary>Total amount of physical memory available to the OS, in KB.</summary>
    public ulong? TotalVisibleMemorySize { get; init; }

    /// <summary>Version number of the operating system (e.g. "10.0.19041").</summary>
    public string? Version { get; init; }

    /// <summary>Windows directory of the operating system.</summary>
    public string? WindowsDirectory { get; init; }
}
