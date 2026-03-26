using Akira;

namespace Akira.Windows;

/// <summary>
/// WMI provider for <see cref="NetworkAdapterConfigurationSnapshot"/>. Queries Win32_NetworkAdapterConfiguration.
/// </summary>
public sealed class NetworkAdapterConfigurationSnapshotProvider : WmiCollectionSnapshotProvider<NetworkAdapterConfigurationSnapshot>
{
    /// <inheritdoc />
    public NetworkAdapterConfigurationSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_NetworkAdapterConfiguration";

    /// <inheritdoc />
    protected override NetworkAdapterConfigurationSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        ArpAlwaysSourceRoute = WmiValueConverter.AsBool(p.GetValueOrDefault("ArpAlwaysSourceRoute")),
        ArpUseEtherSNAP = WmiValueConverter.AsBool(p.GetValueOrDefault("ArpUseEtherSNAP")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        DatabasePath = WmiValueConverter.AsString(p.GetValueOrDefault("DatabasePath")),
        DeadGWDetectEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("DeadGWDetectEnabled")),
        DefaultIPGateway = WmiValueConverter.AsStringArray(p.GetValueOrDefault("DefaultIPGateway")),
        DefaultTOS = WmiValueConverter.AsByte(p.GetValueOrDefault("DefaultTOS")),
        DefaultTTL = WmiValueConverter.AsByte(p.GetValueOrDefault("DefaultTTL")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DHCPEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("DHCPEnabled")),
        DHCPLeaseExpires = WmiValueConverter.AsDateTime(p.GetValueOrDefault("DHCPLeaseExpires")),
        DHCPLeaseObtained = WmiValueConverter.AsDateTime(p.GetValueOrDefault("DHCPLeaseObtained")),
        DHCPServer = WmiValueConverter.AsString(p.GetValueOrDefault("DHCPServer")),
        DNSDomain = WmiValueConverter.AsString(p.GetValueOrDefault("DNSDomain")),
        DNSDomainSuffixSearchOrder = WmiValueConverter.AsStringArray(p.GetValueOrDefault("DNSDomainSuffixSearchOrder")),
        DNSEnabledForWINSResolution = WmiValueConverter.AsBool(p.GetValueOrDefault("DNSEnabledForWINSResolution")),
        DNSHostName = WmiValueConverter.AsString(p.GetValueOrDefault("DNSHostName")),
        DNSServerSearchOrder = WmiValueConverter.AsStringArray(p.GetValueOrDefault("DNSServerSearchOrder")),
        DomainDNSRegistrationEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("DomainDNSRegistrationEnabled")),
        ForwardBufferMemory = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ForwardBufferMemory")),
        FullDNSRegistrationEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("FullDNSRegistrationEnabled")),
        GatewayCostMetric = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("GatewayCostMetric")),
        IGMPLevel = WmiValueConverter.AsByte(p.GetValueOrDefault("IGMPLevel")),
        Index = WmiValueConverter.AsUInt32(p.GetValueOrDefault("Index")),
        InterfaceIndex = WmiValueConverter.AsUInt32(p.GetValueOrDefault("InterfaceIndex")),
        IPAddress = WmiValueConverter.AsStringArray(p.GetValueOrDefault("IPAddress")),
        IPConnectionMetric = WmiValueConverter.AsUInt32(p.GetValueOrDefault("IPConnectionMetric")),
        IPEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("IPEnabled")),
        IPFilterSecurityEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("IPFilterSecurityEnabled")),
        IPPortSecurityEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("IPPortSecurityEnabled")),
        IPSubnet = WmiValueConverter.AsStringArray(p.GetValueOrDefault("IPSubnet")),
        IPUseZeroBroadcast = WmiValueConverter.AsBool(p.GetValueOrDefault("IPUseZeroBroadcast")),
        IPXAddress = WmiValueConverter.AsString(p.GetValueOrDefault("IPXAddress")),
        IPXEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("IPXEnabled")),
        IPXFrameType = WmiValueConverter.AsUInt32Array(p.GetValueOrDefault("IPXFrameType")),
        IPXMediaType = WmiValueConverter.AsUInt32(p.GetValueOrDefault("IPXMediaType")),
        IPXNetworkNumber = WmiValueConverter.AsStringArray(p.GetValueOrDefault("IPXNetworkNumber")),
        IPXVirtualNetNumber = WmiValueConverter.AsString(p.GetValueOrDefault("IPXVirtualNetNumber")),
        KeepAliveInterval = WmiValueConverter.AsUInt32(p.GetValueOrDefault("KeepAliveInterval")),
        KeepAliveTime = WmiValueConverter.AsUInt32(p.GetValueOrDefault("KeepAliveTime")),
        MACAddress = WmiValueConverter.AsString(p.GetValueOrDefault("MACAddress")),
        MTU = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MTU")),
        NumForwardPackets = WmiValueConverter.AsUInt32(p.GetValueOrDefault("NumForwardPackets")),
        PMTUBHDetectEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("PMTUBHDetectEnabled")),
        PMTUDiscoveryEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("PMTUDiscoveryEnabled")),
        ServiceName = WmiValueConverter.AsString(p.GetValueOrDefault("ServiceName")),
        SettingID = WmiValueConverter.AsString(p.GetValueOrDefault("SettingID")),
        TcpipNetbiosOptions = WmiValueConverter.AsUInt16(p.GetValueOrDefault("TcpipNetbiosOptions")),
        TcpMaxConnectRetransmissions = WmiValueConverter.AsUInt32(p.GetValueOrDefault("TcpMaxConnectRetransmissions")),
        TcpMaxDataRetransmissions = WmiValueConverter.AsUInt32(p.GetValueOrDefault("TcpMaxDataRetransmissions")),
        TcpNumConnections = WmiValueConverter.AsUInt32(p.GetValueOrDefault("TcpNumConnections")),
        TcpUseRFC1122UrgentPointer = WmiValueConverter.AsBool(p.GetValueOrDefault("TcpUseRFC1122UrgentPointer")),
        TcpWindowSize = WmiValueConverter.AsUInt16(p.GetValueOrDefault("TcpWindowSize")),
        WINSEnableLMHostsLookup = WmiValueConverter.AsBool(p.GetValueOrDefault("WINSEnableLMHostsLookup")),
        WINSHostLookupFile = WmiValueConverter.AsString(p.GetValueOrDefault("WINSHostLookupFile")),
        WINSPrimaryServer = WmiValueConverter.AsString(p.GetValueOrDefault("WINSPrimaryServer")),
        WINSScopeID = WmiValueConverter.AsString(p.GetValueOrDefault("WINSScopeID")),
        WINSSecondaryServer = WmiValueConverter.AsString(p.GetValueOrDefault("WINSSecondaryServer")),
    };
}
