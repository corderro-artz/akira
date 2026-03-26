namespace Akira;

/// <summary>
/// Snapshot of the system baseboard (motherboard). Maps to Win32_BaseBoard.
/// </summary>
public sealed class BaseBoardSnapshot
{
    /// <summary>Short description of the baseboard.</summary>
    public string? Caption { get; init; }

    /// <summary>Array of configuration option strings for the baseboard jumpers and switches.</summary>
    public string[]? ConfigOptions { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Depth of the baseboard in inches.</summary>
    public float? Depth { get; init; }

    /// <summary>Description of the baseboard.</summary>
    public string? Description { get; init; }

    /// <summary>Height of the baseboard in inches.</summary>
    public float? Height { get; init; }

    /// <summary>Whether the baseboard is a hosting board (i.e. a motherboard).</summary>
    public bool? HostingBoard { get; init; }

    /// <summary>Whether the baseboard is hot-swappable.</summary>
    public bool? HotSwappable { get; init; }

    /// <summary>Date and time the baseboard was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Manufacturer of the baseboard.</summary>
    public string? Manufacturer { get; init; }

    /// <summary>Model of the baseboard.</summary>
    public string? Model { get; init; }

    /// <summary>Label by which the baseboard is known.</summary>
    public string? Name { get; init; }

    /// <summary>Additional data beyond asset tag for identifying the baseboard.</summary>
    public string? OtherIdentifyingInfo { get; init; }

    /// <summary>Part number assigned by the organization responsible for producing the baseboard.</summary>
    public string? PartNumber { get; init; }

    /// <summary>Whether the baseboard is currently powered on.</summary>
    public bool? PoweredOn { get; init; }

    /// <summary>Product identifier of the baseboard.</summary>
    public string? Product { get; init; }

    /// <summary>Whether the baseboard is removable from the chassis.</summary>
    public bool? Removable { get; init; }

    /// <summary>Whether the baseboard is replaceable.</summary>
    public bool? Replaceable { get; init; }

    /// <summary>Free-form string describing the physical package requirements.</summary>
    public string? RequirementsDescription { get; init; }

    /// <summary>Whether the baseboard requires at least one daughter board or auxiliary card.</summary>
    public bool? RequiresDaughterBoard { get; init; }

    /// <summary>Manufacturer-allocated serial number of the baseboard.</summary>
    public string? SerialNumber { get; init; }

    /// <summary>SKU number of the baseboard.</summary>
    public string? SKU { get; init; }

    /// <summary>Free-form description of the slot layout on the baseboard.</summary>
    public string? SlotLayout { get; init; }

    /// <summary>Whether the baseboard has special requirements that must be met.</summary>
    public bool? SpecialRequirements { get; init; }

    /// <summary>Current status of the baseboard.</summary>
    public string? Status { get; init; }

    /// <summary>Uniquely identifies the baseboard among other instances.</summary>
    public string? Tag { get; init; }

    /// <summary>Version of the baseboard.</summary>
    public string? Version { get; init; }

    /// <summary>Weight of the baseboard in pounds.</summary>
    public float? Weight { get; init; }

    /// <summary>Width of the baseboard in inches.</summary>
    public float? Width { get; init; }
}
