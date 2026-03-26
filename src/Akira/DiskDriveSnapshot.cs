namespace Vaporsoft.Akira;

/// <summary>
/// Snapshot of a physical disk drive. Maps to Win32_DiskDrive.
/// </summary>
public sealed class DiskDriveSnapshot
{
    /// <summary>Availability and status of the device.</summary>
    public ushort? Availability { get; init; }

    /// <summary>Number of bytes in each sector.</summary>
    public uint? BytesPerSector { get; init; }

    /// <summary>Array of disk capabilities (e.g. 3 = Random Access, 4 = Supports Writing).</summary>
    public ushort[]? Capabilities { get; init; }

    /// <summary>Descriptions of the disk capabilities.</summary>
    public string[]? CapabilityDescriptions { get; init; }

    /// <summary>Short description of the disk drive.</summary>
    public string? Caption { get; init; }

    /// <summary>Manufacturer's compression method.</summary>
    public string? CompressionMethod { get; init; }

    /// <summary>Win32 Configuration Manager error code.</summary>
    public uint? ConfigManagerErrorCode { get; init; }

    /// <summary>Whether the device uses a user-defined configuration.</summary>
    public bool? ConfigManagerUserConfig { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Default block size in bytes.</summary>
    public ulong? DefaultBlockSize { get; init; }

    /// <summary>Description of the disk drive.</summary>
    public string? Description { get; init; }

    /// <summary>Unique identifier of the disk drive.</summary>
    public string? DeviceID { get; init; }

    /// <summary>Whether the error reported in LastErrorCode has been cleared.</summary>
    public bool? ErrorCleared { get; init; }

    /// <summary>Free-form string about the last error.</summary>
    public string? ErrorDescription { get; init; }

    /// <summary>Type of error detection and correction.</summary>
    public string? ErrorMethodology { get; init; }

    /// <summary>Physical drive number (e.g. "\\.\PHYSICALDRIVE0").</summary>
    public string? FirmwareRevision { get; init; }

    /// <summary>Disk drive index number.</summary>
    public uint? Index { get; init; }

    /// <summary>Date and time the object was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Interface type of the physical disk drive.</summary>
    public string? InterfaceType { get; init; }

    /// <summary>Last error code reported by the logical device.</summary>
    public uint? LastErrorCode { get; init; }

    /// <summary>Manufacturer of the disk drive.</summary>
    public string? Manufacturer { get; init; }

    /// <summary>Maximum block size in bytes.</summary>
    public ulong? MaxBlockSize { get; init; }

    /// <summary>Maximum media size in KB.</summary>
    public ulong? MaxMediaSize { get; init; }

    /// <summary>Whether the media can be read from.</summary>
    public bool? MediaLoaded { get; init; }

    /// <summary>Type of media used or accessed by the device.</summary>
    public string? MediaType { get; init; }

    /// <summary>Minimum block size in bytes.</summary>
    public ulong? MinBlockSize { get; init; }

    /// <summary>Manufacturer's model number of the disk drive.</summary>
    public string? Model { get; init; }

    /// <summary>Label by which the object is known.</summary>
    public string? Name { get; init; }

    /// <summary>Whether the media access device needs cleaning.</summary>
    public bool? NeedsCleaning { get; init; }

    /// <summary>Maximum number of media that can be supported/inserted.</summary>
    public uint? NumberOfMediaSupported { get; init; }

    /// <summary>Number of partitions on the disk drive.</summary>
    public uint? Partitions { get; init; }

    /// <summary>Windows Plug and Play device identifier.</summary>
    public string? PNPDeviceID { get; init; }

    /// <summary>Array of power-related capabilities.</summary>
    public ushort[]? PowerManagementCapabilities { get; init; }

    /// <summary>Whether the device can be power-managed.</summary>
    public bool? PowerManagementSupported { get; init; }

    /// <summary>Number of SCSI bus used to access this drive.</summary>
    public uint? SCSIBus { get; init; }

    /// <summary>SCSI logical unit number (LUN).</summary>
    public ushort? SCSILogicalUnit { get; init; }

    /// <summary>SCSI port number.</summary>
    public ushort? SCSIPort { get; init; }

    /// <summary>SCSI target ID.</summary>
    public ushort? SCSITargetId { get; init; }

    /// <summary>Number of sectors in each track.</summary>
    public uint? SectorsPerTrack { get; init; }

    /// <summary>Serial number of the disk drive.</summary>
    public string? SerialNumber { get; init; }

    /// <summary>Disk identification (signature/MBR).</summary>
    public uint? Signature { get; init; }

    /// <summary>Size of the disk drive in bytes.</summary>
    public ulong? Size { get; init; }

    /// <summary>Current status of the object.</summary>
    public string? Status { get; init; }

    /// <summary>State of the logical device.</summary>
    public ushort? StatusInfo { get; init; }

    /// <summary>CreationClassName of the scoping computer system.</summary>
    public string? SystemCreationClassName { get; init; }

    /// <summary>Name of the scoping system.</summary>
    public string? SystemName { get; init; }

    /// <summary>Total number of cylinders on the disk drive.</summary>
    public ulong? TotalCylinders { get; init; }

    /// <summary>Total number of heads on the disk drive.</summary>
    public uint? TotalHeads { get; init; }

    /// <summary>Total number of sectors on the disk drive.</summary>
    public ulong? TotalSectors { get; init; }

    /// <summary>Total number of tracks on the disk drive.</summary>
    public ulong? TotalTracks { get; init; }

    /// <summary>Number of tracks in each cylinder.</summary>
    public uint? TracksPerCylinder { get; init; }
}
