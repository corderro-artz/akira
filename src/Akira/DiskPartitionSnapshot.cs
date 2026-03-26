namespace Vaporsoft.Akira;

/// <summary>
/// Snapshot of a disk partition. Maps to Win32_DiskPartition.
/// </summary>
public sealed class DiskPartitionSnapshot
{
    /// <summary>Additional availability of the partition beyond that specified in the Availability property.</summary>
    public ushort? AdditionalAvailability { get; init; }

    /// <summary>Type of media access available (0 = Unknown, 1 = Readable, 2 = Writeable, etc.).</summary>
    public ushort? Access { get; init; }

    /// <summary>Availability and status of the device.</summary>
    public ushort? Availability { get; init; }

    /// <summary>Size in bytes of the blocks that form the storage extent.</summary>
    public ulong? BlockSize { get; init; }

    /// <summary>Whether the disk partition is the bootable partition.</summary>
    public bool? Bootable { get; init; }

    /// <summary>Whether this is the partition from which the computer boots.</summary>
    public bool? BootPartition { get; init; }

    /// <summary>Short description of the disk partition.</summary>
    public string? Caption { get; init; }

    /// <summary>Win32 Configuration Manager error code.</summary>
    public uint? ConfigManagerErrorCode { get; init; }

    /// <summary>Whether the device is using a user-defined configuration.</summary>
    public bool? ConfigManagerUserConfig { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Description of the disk partition.</summary>
    public string? Description { get; init; }

    /// <summary>Unique identifier of the disk partition.</summary>
    public string? DeviceID { get; init; }

    /// <summary>Index number of the disk containing the partition.</summary>
    public uint? DiskIndex { get; init; }

    /// <summary>Whether the error reported in LastErrorCode has been cleared.</summary>
    public bool? ErrorCleared { get; init; }

    /// <summary>Free-form string providing information about the last error.</summary>
    public string? ErrorDescription { get; init; }

    /// <summary>Type of error detection and correction supported by the device.</summary>
    public string? ErrorMethodology { get; init; }

    /// <summary>Number of hidden sectors in the partition.</summary>
    public uint? HiddenSectors { get; init; }

    /// <summary>Array of identifying descriptions for the partition.</summary>
    public string[]? IdentifyingDescriptions { get; init; }

    /// <summary>Index number of the partition.</summary>
    public uint? Index { get; init; }

    /// <summary>Date and time the partition was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Last error code reported by the logical device.</summary>
    public uint? LastErrorCode { get; init; }

    /// <summary>Maximum time in milliseconds during which device can remain in a quiesced state.</summary>
    public ulong? MaxQuiesceTime { get; init; }

    /// <summary>Label by which the partition is known.</summary>
    public string? Name { get; init; }

    /// <summary>Total number of consecutive blocks that form the storage extent.</summary>
    public ulong? NumberOfBlocks { get; init; }

    /// <summary>Additional data beyond DeviceID to identify the logical device.</summary>
    public ulong? OtherIdentifyingInfo { get; init; }

    /// <summary>Windows Plug and Play device identifier of the logical device.</summary>
    public string? PNPDeviceID { get; init; }

    /// <summary>Array of power management capabilities of the device.</summary>
    public ushort[]? PowerManagementCapabilities { get; init; }

    /// <summary>Whether the device supports power management.</summary>
    public bool? PowerManagementSupported { get; init; }

    /// <summary>Total number of hours the device has been powered on.</summary>
    public ulong? PowerOnHours { get; init; }

    /// <summary>Whether this is the primary partition.</summary>
    public bool? PrimaryPartition { get; init; }

    /// <summary>Free-form string describing the media and its use.</summary>
    public string? Purpose { get; init; }

    /// <summary>Whether the partition information has been rewritten.</summary>
    public bool? RewritePartition { get; init; }

    /// <summary>Total size of the partition in bytes.</summary>
    public ulong? Size { get; init; }

    /// <summary>Starting offset of the partition from the beginning of the disk in bytes.</summary>
    public ulong? StartingOffset { get; init; }

    /// <summary>Current status of the partition.</summary>
    public string? Status { get; init; }

    /// <summary>State of the logical device.</summary>
    public ushort? StatusInfo { get; init; }

    /// <summary>Scoping system's CreationClassName.</summary>
    public string? SystemCreationClassName { get; init; }

    /// <summary>Name of the scoping system.</summary>
    public string? SystemName { get; init; }

    /// <summary>Total number of hours the device has been powered on since manufacture.</summary>
    public ulong? TotalPowerOnHours { get; init; }

    /// <summary>Type of the partition (e.g. "GPT: Basic Data", "Installable File System").</summary>
    public string? Type { get; init; }
}
