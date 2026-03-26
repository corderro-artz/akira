namespace Vaporsoft.Akira;

/// <summary>
/// Snapshot of a physical memory module. Maps to Win32_PhysicalMemory.
/// </summary>
public sealed class PhysicalMemorySnapshot
{
    /// <summary>SMBIOS Type 17 attributes representing the RANK.</summary>
    public uint? Attributes { get; init; }

    /// <summary>Physically labeled bank where the memory is located.</summary>
    public string? BankLabel { get; init; }

    /// <summary>Total capacity of the physical memory in bytes.</summary>
    public ulong? Capacity { get; init; }

    /// <summary>Short description of the memory module.</summary>
    public string? Caption { get; init; }

    /// <summary>Configured clock speed in MHz, or 0 if unknown.</summary>
    public uint? ConfiguredClockSpeed { get; init; }

    /// <summary>Configured voltage in millivolts, or 0 if unknown.</summary>
    public uint? ConfiguredVoltage { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Data width of the physical memory in bits.</summary>
    public ushort? DataWidth { get; init; }

    /// <summary>Description of the memory module.</summary>
    public string? Description { get; init; }

    /// <summary>Label of the socket or circuit board that holds the memory.</summary>
    public string? DeviceLocator { get; init; }

    /// <summary>Implementation form factor (0 = Unknown, 8 = DIMM, 12 = SODIMM, etc.).</summary>
    public ushort? FormFactor { get; init; }

    /// <summary>Whether the component can be hot-swapped.</summary>
    public bool? HotSwappable { get; init; }

    /// <summary>Date and time the object was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Maximum consecutive rows accessed in a single interleaved transfer.</summary>
    public ushort? InterleaveDataDepth { get; init; }

    /// <summary>Position of the physical memory in an interleave.</summary>
    public uint? InterleavePosition { get; init; }

    /// <summary>Name of the organization that produced the memory.</summary>
    public string? Manufacturer { get; init; }

    /// <summary>Maximum operating voltage in millivolts, or 0 if unknown.</summary>
    public uint? MaxVoltage { get; init; }

    /// <summary>CIM memory type (0 = Unknown, 20 = DDR, 21 = DDR2, etc.).</summary>
    public ushort? MemoryType { get; init; }

    /// <summary>Minimum operating voltage in millivolts, or 0 if unknown.</summary>
    public uint? MinVoltage { get; init; }

    /// <summary>Name of the physical element model.</summary>
    public string? Model { get; init; }

    /// <summary>Label by which the object is known.</summary>
    public string? Name { get; init; }

    /// <summary>Additional identifying information (e.g. bar code data).</summary>
    public string? OtherIdentifyingInfo { get; init; }

    /// <summary>Part number assigned by the manufacturer.</summary>
    public string? PartNumber { get; init; }

    /// <summary>Position of the physical memory in a row.</summary>
    public uint? PositionInRow { get; init; }

    /// <summary>Whether the physical element is powered on.</summary>
    public bool? PoweredOn { get; init; }

    /// <summary>Whether the component is removable.</summary>
    public bool? Removable { get; init; }

    /// <summary>Whether the component can be replaced with a different one.</summary>
    public bool? Replaceable { get; init; }

    /// <summary>Manufacturer-allocated serial number.</summary>
    public string? SerialNumber { get; init; }

    /// <summary>Stock keeping unit number.</summary>
    public string? SKU { get; init; }

    /// <summary>Raw SMBIOS memory type value.</summary>
    public uint? SMBIOSMemoryType { get; init; }

    /// <summary>Speed of the physical memory in nanoseconds.</summary>
    public uint? Speed { get; init; }

    /// <summary>Current status of the object.</summary>
    public string? Status { get; init; }

    /// <summary>Unique identifier for the physical memory device.</summary>
    public string? Tag { get; init; }

    /// <summary>Total width of the physical memory in bits (including ECC).</summary>
    public ushort? TotalWidth { get; init; }

    /// <summary>Type detail bit flags (1 = Reserved, 128 = Synchronous, etc.).</summary>
    public ushort? TypeDetail { get; init; }

    /// <summary>Version of the physical element.</summary>
    public string? Version { get; init; }
}
