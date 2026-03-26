namespace Vaporsoft.Akira;

/// <summary>
/// Snapshot of the computer system product. Maps to Win32_ComputerSystemProduct.
/// </summary>
public sealed class ComputerSystemProductSnapshot
{
    /// <summary>Short description of the computer system product.</summary>
    public string? Caption { get; init; }

    /// <summary>Description of the computer system product.</summary>
    public string? Description { get; init; }

    /// <summary>Product identification such as a serial number on hardware or a die number on a chip.</summary>
    public string? IdentifyingNumber { get; init; }

    /// <summary>Commonly used product name.</summary>
    public string? Name { get; init; }

    /// <summary>Product SKU number.</summary>
    public string? SKUNumber { get; init; }

    /// <summary>Universally unique identifier (UUID) for this product.</summary>
    public string? UUID { get; init; }

    /// <summary>Name of the product vendor.</summary>
    public string? Vendor { get; init; }

    /// <summary>Product version.</summary>
    public string? Version { get; init; }
}
