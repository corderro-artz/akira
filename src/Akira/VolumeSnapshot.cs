namespace Akira;

/// <summary>
/// Snapshot of a storage volume. Maps to Win32_Volume.
/// </summary>
public sealed class VolumeSnapshot
{
    /// <summary>Type of media access available (0 = Unknown, 1 = Readable, 2 = Writeable, etc.).</summary>
    public ushort? Access { get; init; }

    /// <summary>Whether the volume is automatically mounted when it is added to the system.</summary>
    public bool? Automount { get; init; }

    /// <summary>Availability and status of the device.</summary>
    public ushort? Availability { get; init; }

    /// <summary>Size in bytes of the blocks that form the storage extent.</summary>
    public ulong? BlockSize { get; init; }

    /// <summary>Total capacity of the volume in bytes.</summary>
    public ulong? Capacity { get; init; }

    /// <summary>Short description of the volume.</summary>
    public string? Caption { get; init; }

    /// <summary>Whether the volume is compressed.</summary>
    public bool? Compressed { get; init; }

    /// <summary>Win32 Configuration Manager error code.</summary>
    public uint? ConfigManagerErrorCode { get; init; }

    /// <summary>Whether the device is using a user-defined configuration.</summary>
    public bool? ConfigManagerUserConfig { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Description of the volume.</summary>
    public string? Description { get; init; }

    /// <summary>Unique identifier of the volume.</summary>
    public string? DeviceID { get; init; }

    /// <summary>Whether the volume dirty bit is set.</summary>
    public bool? DirtyBitSet { get; init; }

    /// <summary>Drive letter assigned to the volume (e.g. "C:").</summary>
    public string? DriveLetter { get; init; }

    /// <summary>Type of disk drive the volume represents (0 = Unknown, 2 = Removable, 3 = Fixed, etc.).</summary>
    public uint? DriveType { get; init; }

    /// <summary>Whether the error reported in LastErrorCode has been cleared.</summary>
    public bool? ErrorCleared { get; init; }

    /// <summary>Free-form string providing information about the last error.</summary>
    public string? ErrorDescription { get; init; }

    /// <summary>Type of error detection and correction supported by the device.</summary>
    public string? ErrorMethodology { get; init; }

    /// <summary>File system on the volume (e.g. "NTFS", "FAT32", "ReFS").</summary>
    public string? FileSystem { get; init; }

    /// <summary>Number of bytes of free space available on the volume.</summary>
    public ulong? FreeSpace { get; init; }

    /// <summary>Whether content indexing is enabled on the volume.</summary>
    public bool? IndexingEnabled { get; init; }

    /// <summary>Date and time the volume was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Volume label (user-friendly name).</summary>
    public string? Label { get; init; }

    /// <summary>Last error code reported by the logical device.</summary>
    public uint? LastErrorCode { get; init; }

    /// <summary>Maximum length of a file name component supported by the file system.</summary>
    public uint? MaximumFileNameLength { get; init; }

    /// <summary>Label by which the volume is known.</summary>
    public string? Name { get; init; }

    /// <summary>Total number of consecutive blocks that form the storage extent.</summary>
    public ulong? NumberOfBlocks { get; init; }

    /// <summary>Windows Plug and Play device identifier.</summary>
    public string? PNPDeviceID { get; init; }

    /// <summary>Array of power management capabilities of the device.</summary>
    public ushort[]? PowerManagementCapabilities { get; init; }

    /// <summary>Whether the device supports power management.</summary>
    public bool? PowerManagementSupported { get; init; }

    /// <summary>Free-form string describing the media and its use.</summary>
    public string? Purpose { get; init; }

    /// <summary>Whether disk quotas are enabled on the volume.</summary>
    public bool? QuotasEnabled { get; init; }

    /// <summary>Whether the disk quota scan is incomplete.</summary>
    public bool? QuotasIncomplete { get; init; }

    /// <summary>Whether the disk quota system is rebuilding its information.</summary>
    public bool? QuotasRebuilding { get; init; }

    /// <summary>Serial number of the volume.</summary>
    public uint? SerialNumber { get; init; }

    /// <summary>Current status of the volume.</summary>
    public string? Status { get; init; }

    /// <summary>State of the logical device.</summary>
    public ushort? StatusInfo { get; init; }

    /// <summary>Whether the volume supports disk quotas.</summary>
    public bool? SupportsDiskQuotas { get; init; }

    /// <summary>Whether the file system supports file-based compression.</summary>
    public bool? SupportsFileBasedCompression { get; init; }

    /// <summary>Scoping system's CreationClassName.</summary>
    public string? SystemCreationClassName { get; init; }

    /// <summary>Name of the scoping system.</summary>
    public string? SystemName { get; init; }
}
