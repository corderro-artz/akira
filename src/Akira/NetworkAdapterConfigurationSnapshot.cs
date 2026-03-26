namespace Vaporsoft.Akira;

/// <summary>
/// Snapshot of a network adapter configuration. Maps to Win32_NetworkAdapterConfiguration.
/// </summary>
public sealed class NetworkAdapterConfigurationSnapshot
{
    /// <summary>Whether ARP always uses Ethernet encapsulation.</summary>
    public bool? ArpAlwaysSourceRoute { get; init; }

    /// <summary>Whether ARP uses Ethernet (false) or 802.3 SNAP (true) encapsulation.</summary>
    public bool? ArpUseEtherSNAP { get; init; }

    /// <summary>Short description of the network adapter configuration.</summary>
    public string? Caption { get; init; }

    /// <summary>Valid Windows character set code page on the system.</summary>
    public string? DatabasePath { get; init; }

    /// <summary>Whether dead gateway detection is active.</summary>
    public bool? DeadGWDetectEnabled { get; init; }

    /// <summary>Array of IP addresses of default gateways.</summary>
    public string[]? DefaultIPGateway { get; init; }

    /// <summary>Default Type Of Service value in IP headers.</summary>
    public byte? DefaultTOS { get; init; }

    /// <summary>Default Time To Live value in IP headers.</summary>
    public byte? DefaultTTL { get; init; }

    /// <summary>Description of the network adapter configuration.</summary>
    public string? Description { get; init; }

    /// <summary>Whether DHCP is enabled for this adapter.</summary>
    public bool? DHCPEnabled { get; init; }

    /// <summary>Date/time the current DHCP lease expires.</summary>
    public DateTime? DHCPLeaseExpires { get; init; }

    /// <summary>Date/time the current DHCP lease was obtained.</summary>
    public DateTime? DHCPLeaseObtained { get; init; }

    /// <summary>IP address of the DHCP server.</summary>
    public string? DHCPServer { get; init; }

    /// <summary>Organization name followed by a period and DNS domain.</summary>
    public string? DNSDomain { get; init; }

    /// <summary>Array of DNS domain suffixes to search.</summary>
    public string[]? DNSDomainSuffixSearchOrder { get; init; }

    /// <summary>Whether DNS is enabled for name resolution on this adapter.</summary>
    public bool? DNSEnabledForWINSResolution { get; init; }

    /// <summary>Host name portion of the DNS name.</summary>
    public string? DNSHostName { get; init; }

    /// <summary>Array of DNS server IP addresses.</summary>
    public string[]? DNSServerSearchOrder { get; init; }

    /// <summary>Whether domain DNS registration is enabled.</summary>
    public bool? DomainDNSRegistrationEnabled { get; init; }

    /// <summary>Forward buffer memory allocated for storing packets.</summary>
    public uint? ForwardBufferMemory { get; init; }

    /// <summary>Whether full DNS registration is enabled.</summary>
    public bool? FullDNSRegistrationEnabled { get; init; }

    /// <summary>Array of gateway cost metrics.</summary>
    public ushort[]? GatewayCostMetric { get; init; }

    /// <summary>IGMP level (0 = None, 1 = IP Multicast, 3 = IP and IGMP).</summary>
    public byte? IGMPLevel { get; init; }

    /// <summary>Index of the network adapter configuration.</summary>
    public uint? Index { get; init; }

    /// <summary>Index value that uniquely identifies a local network interface.</summary>
    public uint? InterfaceIndex { get; init; }

    /// <summary>Array of IP addresses assigned to the adapter.</summary>
    public string[]? IPAddress { get; init; }

    /// <summary>Cost of using this IP-bound adapter.</summary>
    public uint? IPConnectionMetric { get; init; }

    /// <summary>Whether IP is enabled on this adapter.</summary>
    public bool? IPEnabled { get; init; }

    /// <summary>Whether IP port security is enabled globally.</summary>
    public bool? IPFilterSecurityEnabled { get; init; }

    /// <summary>Whether IP port security is enabled for this adapter.</summary>
    public bool? IPPortSecurityEnabled { get; init; }

    /// <summary>Array of IP subnet masks.</summary>
    public string[]? IPSubnet { get; init; }

    /// <summary>Whether LMHOSTS lookup is used.</summary>
    public bool? IPUseZeroBroadcast { get; init; }

    /// <summary>IP X address for this adapter.</summary>
    public string? IPXAddress { get; init; }

    /// <summary>Whether IPX is enabled for this adapter.</summary>
    public bool? IPXEnabled { get; init; }

    /// <summary>IPX frame types.</summary>
    public uint[]? IPXFrameType { get; init; }

    /// <summary>IPX media type.</summary>
    public uint? IPXMediaType { get; init; }

    /// <summary>IPX network numbers.</summary>
    public string[]? IPXNetworkNumber { get; init; }

    /// <summary>IPX virtual network number.</summary>
    public string? IPXVirtualNetNumber { get; init; }

    /// <summary>Interval in seconds between keep-alive transmissions.</summary>
    public uint? KeepAliveInterval { get; init; }

    /// <summary>Time in milliseconds the first keep-alive packet is sent.</summary>
    public uint? KeepAliveTime { get; init; }

    /// <summary>MAC address in colon-delimited format.</summary>
    public string? MACAddress { get; init; }

    /// <summary>Maximum transmission unit (bytes).</summary>
    public uint? MTU { get; init; }

    /// <summary>Maximum number of datagrams that can be reassembled.</summary>
    public uint? NumForwardPackets { get; init; }

    /// <summary>Whether PMTU discovery is enabled for black-hole routers.</summary>
    public bool? PMTUBHDetectEnabled { get; init; }

    /// <summary>Whether path MTU discovery is enabled.</summary>
    public bool? PMTUDiscoveryEnabled { get; init; }

    /// <summary>Service name of the network adapter.</summary>
    public string? ServiceName { get; init; }

    /// <summary>Identifier for the configuration settings.</summary>
    public string? SettingID { get; init; }

    /// <summary>Maximum TCP receive window size in bytes.</summary>
    public ushort? TcpipNetbiosOptions { get; init; }

    /// <summary>Maximum number of connections TCP can have open simultaneously.</summary>
    public uint? TcpMaxConnectRetransmissions { get; init; }

    /// <summary>Max retransmissions for data segments.</summary>
    public uint? TcpMaxDataRetransmissions { get; init; }

    /// <summary>Number of duplicate ACKs before fast retransmit.</summary>
    public uint? TcpNumConnections { get; init; }

    /// <summary>Whether TCP timestamps (RFC 1323) are enabled.</summary>
    public bool? TcpUseRFC1122UrgentPointer { get; init; }

    /// <summary>TCP window size in bytes.</summary>
    public ushort? TcpWindowSize { get; init; }

    /// <summary>Whether WINS lookup files are enabled.</summary>
    public bool? WINSEnableLMHostsLookup { get; init; }

    /// <summary>Path to LMHOSTS file.</summary>
    public string? WINSHostLookupFile { get; init; }

    /// <summary>IP address of the primary WINS server.</summary>
    public string? WINSPrimaryServer { get; init; }

    /// <summary>WINS scope ID for this adapter.</summary>
    public string? WINSScopeID { get; init; }

    /// <summary>IP address of the secondary WINS server.</summary>
    public string? WINSSecondaryServer { get; init; }
}
