namespace Vaporsoft.Akira;

/// <summary>
/// Snapshot of a logical disk volume. Maps to Win32_LogicalDisk.
/// </summary>
public sealed class LogicalDiskSnapshot
{
    /// <summary>Type of disk access (0 = Unknown, 1 = Readable, 2 = Writeable, 3 = Read/Write).</summary>
    public ushort? Access { get; init; }

    /// <summary>Availability and status of the device.</summary>
    public ushort? Availability { get; init; }

    /// <summary>Block size of the logical disk in bytes.</summary>
    public ulong? BlockSize { get; init; }

    /// <summary>Short description of the logical disk.</summary>
    public string? Caption { get; init; }

    /// <summary>Whether the logical volume is compressed.</summary>
    public bool? Compressed { get; init; }

    /// <summary>Win32 Configuration Manager error code.</summary>
    public uint? ConfigManagerErrorCode { get; init; }

    /// <summary>Whether the device uses a user-defined configuration.</summary>
    public bool? ConfigManagerUserConfig { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Description of the logical disk.</summary>
    public string? Description { get; init; }

    /// <summary>Unique identifier of the logical disk (e.g. "C:").</summary>
    public string? DeviceID { get; init; }

    /// <summary>Type of disk drive (0 = Unknown, 2 = Removable, 3 = Fixed, 4 = Network, 5 = CD-ROM, 6 = RAM Disk).</summary>
    public uint? DriveType { get; init; }

    /// <summary>Whether the error reported in LastErrorCode has been cleared.</summary>
    public bool? ErrorCleared { get; init; }

    /// <summary>Free-form string about the last error.</summary>
    public string? ErrorDescription { get; init; }

    /// <summary>Type of error detection and correction.</summary>
    public string? ErrorMethodology { get; init; }

    /// <summary>File system of the logical disk (e.g. "NTFS").</summary>
    public string? FileSystem { get; init; }

    /// <summary>Free space in bytes.</summary>
    public ulong? FreeSpace { get; init; }

    /// <summary>Date and time the object was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Last error code reported by the logical device.</summary>
    public uint? LastErrorCode { get; init; }

    /// <summary>Maximum length of a filename component (between backslashes).</summary>
    public uint? MaximumComponentLength { get; init; }

    /// <summary>Type of media currently in the logical drive.</summary>
    public uint? MediaType { get; init; }

    /// <summary>Label by which the object is known.</summary>
    public string? Name { get; init; }

    /// <summary>Number of blocks in the logical disk.</summary>
    public ulong? NumberOfBlocks { get; init; }

    /// <summary>Windows Plug and Play device identifier.</summary>
    public string? PNPDeviceID { get; init; }

    /// <summary>Array of power-related capabilities.</summary>
    public ushort[]? PowerManagementCapabilities { get; init; }

    /// <summary>Whether the device can be power-managed.</summary>
    public bool? PowerManagementSupported { get; init; }

    /// <summary>Network path to the logical device (for network drives).</summary>
    public string? ProviderName { get; init; }

    /// <summary>Free-form string describing the media and its use.</summary>
    public string? Purpose { get; init; }

    /// <summary>If true, supports quotas.</summary>
    public bool? QuotasDisabled { get; init; }

    /// <summary>If true, quota limits are enforced.</summary>
    public bool? QuotasIncomplete { get; init; }

    /// <summary>If true, quota system rebuilding is in progress.</summary>
    public bool? QuotasRebuilding { get; init; }

    /// <summary>Size of the disk in bytes.</summary>
    public ulong? Size { get; init; }

    /// <summary>Current status of the object.</summary>
    public string? Status { get; init; }

    /// <summary>State of the logical device.</summary>
    public ushort? StatusInfo { get; init; }

    /// <summary>Whether file-based compression is supported.</summary>
    public bool? SupportsDiskQuotas { get; init; }

    /// <summary>Whether the logical disk partition supports file-based compression.</summary>
    public bool? SupportsFileBasedCompression { get; init; }

    /// <summary>CreationClassName of the scoping computer system.</summary>
    public string? SystemCreationClassName { get; init; }

    /// <summary>Name of the scoping system.</summary>
    public string? SystemName { get; init; }

    /// <summary>Volume name of the logical disk.</summary>
    public string? VolumeName { get; init; }

    /// <summary>Volume serial number of the logical disk.</summary>
    public string? VolumeSerialNumber { get; init; }
}
