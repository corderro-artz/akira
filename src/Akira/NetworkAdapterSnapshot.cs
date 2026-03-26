namespace Akira;

/// <summary>
/// Snapshot of a network adapter. Maps to Win32_NetworkAdapter.
/// </summary>
public sealed class NetworkAdapterSnapshot
{
    /// <summary>Network medium in use (e.g. "Ethernet 802.3").</summary>
    public string? AdapterType { get; init; }

    /// <summary>Network medium identifier.</summary>
    public ushort? AdapterTypeId { get; init; }

    /// <summary>Whether the adapter can auto-sense media speed.</summary>
    public bool? AutoSense { get; init; }

    /// <summary>Availability and status of the device.</summary>
    public ushort? Availability { get; init; }

    /// <summary>Short description of the network adapter.</summary>
    public string? Caption { get; init; }

    /// <summary>Win32 Configuration Manager error code.</summary>
    public uint? ConfigManagerErrorCode { get; init; }

    /// <summary>Whether the device uses a user-defined configuration.</summary>
    public bool? ConfigManagerUserConfig { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Description of the network adapter.</summary>
    public string? Description { get; init; }

    /// <summary>Unique identifier of the network adapter.</summary>
    public string? DeviceID { get; init; }

    /// <summary>Whether the error reported in LastErrorCode has been cleared.</summary>
    public bool? ErrorCleared { get; init; }

    /// <summary>Free-form string about the last error.</summary>
    public string? ErrorDescription { get; init; }

    /// <summary>Globally unique identifier for the connection.</summary>
    public string? GUID { get; init; }

    /// <summary>Index value that uniquely identifies the local network interface.</summary>
    public uint? Index { get; init; }

    /// <summary>Date and time the object was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Whether the adapter is installed.</summary>
    public bool? Installed { get; init; }

    /// <summary>Index value of this interface used for routing.</summary>
    public uint? InterfaceIndex { get; init; }

    /// <summary>Last error code reported by the logical device.</summary>
    public uint? LastErrorCode { get; init; }

    /// <summary>Media access control address for the network adapter.</summary>
    public string? MACAddress { get; init; }

    /// <summary>Manufacturer of the network adapter.</summary>
    public string? Manufacturer { get; init; }

    /// <summary>Maximum number of directly addressable ports on this adapter.</summary>
    public uint? MaxNumberControlled { get; init; }

    /// <summary>Maximum speed of the network adapter in bits per second.</summary>
    public ulong? MaxSpeed { get; init; }

    /// <summary>Label by which the object is known.</summary>
    public string? Name { get; init; }

    /// <summary>Name of the network connection as it appears in Control Panel.</summary>
    public string? NetConnectionID { get; init; }

    /// <summary>State of the network connection (0 = Disconnected, 2 = Connected, etc.).</summary>
    public ushort? NetConnectionStatus { get; init; }

    /// <summary>Whether the adapter is enabled or not.</summary>
    public bool? NetEnabled { get; init; }

    /// <summary>Array of network addresses for an adapter.</summary>
    public string[]? NetworkAddresses { get; init; }

    /// <summary>Permanent MAC address burned into the adapter.</summary>
    public string? PermanentAddress { get; init; }

    /// <summary>Whether the adapter is a physical or logical adapter.</summary>
    public bool? PhysicalAdapter { get; init; }

    /// <summary>Windows Plug and Play device identifier.</summary>
    public string? PNPDeviceID { get; init; }

    /// <summary>Array of power-related capabilities.</summary>
    public ushort[]? PowerManagementCapabilities { get; init; }

    /// <summary>Whether the device can be power-managed.</summary>
    public bool? PowerManagementSupported { get; init; }

    /// <summary>Product name of the network adapter.</summary>
    public string? ProductName { get; init; }

    /// <summary>Service name of the network adapter.</summary>
    public string? ServiceName { get; init; }

    /// <summary>Estimated current bandwidth in bits per second.</summary>
    public ulong? Speed { get; init; }

    /// <summary>Current status of the object.</summary>
    public string? Status { get; init; }

    /// <summary>State of the logical device.</summary>
    public ushort? StatusInfo { get; init; }

    /// <summary>CreationClassName of the scoping computer system.</summary>
    public string? SystemCreationClassName { get; init; }

    /// <summary>Name of the scoping system.</summary>
    public string? SystemName { get; init; }

    /// <summary>Date and time of the last network adapter reset.</summary>
    public DateTime? TimeOfLastReset { get; init; }
}
