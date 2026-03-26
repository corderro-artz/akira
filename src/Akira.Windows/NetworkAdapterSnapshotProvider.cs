using Akira;

namespace Akira.Windows;

/// <summary>
/// WMI provider for <see cref="NetworkAdapterSnapshot"/>. Queries Win32_NetworkAdapter.
/// </summary>
public sealed class NetworkAdapterSnapshotProvider : WmiCollectionSnapshotProvider<NetworkAdapterSnapshot>
{
    /// <inheritdoc />
    public NetworkAdapterSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_NetworkAdapter";

    /// <inheritdoc />
    protected override NetworkAdapterSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        AdapterType = WmiValueConverter.AsString(p.GetValueOrDefault("AdapterType")),
        AdapterTypeId = WmiValueConverter.AsUInt16(p.GetValueOrDefault("AdapterTypeId")),
        AutoSense = WmiValueConverter.AsBool(p.GetValueOrDefault("AutoSense")),
        Availability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Availability")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        ConfigManagerErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfigManagerErrorCode")),
        ConfigManagerUserConfig = WmiValueConverter.AsBool(p.GetValueOrDefault("ConfigManagerUserConfig")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("DeviceID")),
        ErrorCleared = WmiValueConverter.AsBool(p.GetValueOrDefault("ErrorCleared")),
        ErrorDescription = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorDescription")),
        GUID = WmiValueConverter.AsString(p.GetValueOrDefault("GUID")),
        Index = WmiValueConverter.AsUInt32(p.GetValueOrDefault("Index")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        Installed = WmiValueConverter.AsBool(p.GetValueOrDefault("Installed")),
        InterfaceIndex = WmiValueConverter.AsUInt32(p.GetValueOrDefault("InterfaceIndex")),
        LastErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("LastErrorCode")),
        MACAddress = WmiValueConverter.AsString(p.GetValueOrDefault("MACAddress")),
        Manufacturer = WmiValueConverter.AsString(p.GetValueOrDefault("Manufacturer")),
        MaxNumberControlled = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaxNumberControlled")),
        MaxSpeed = WmiValueConverter.AsUInt64(p.GetValueOrDefault("MaxSpeed")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        NetConnectionID = WmiValueConverter.AsString(p.GetValueOrDefault("NetConnectionID")),
        NetConnectionStatus = WmiValueConverter.AsUInt16(p.GetValueOrDefault("NetConnectionStatus")),
        NetEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("NetEnabled")),
        NetworkAddresses = WmiValueConverter.AsStringArray(p.GetValueOrDefault("NetworkAddresses")),
        PermanentAddress = WmiValueConverter.AsString(p.GetValueOrDefault("PermanentAddress")),
        PhysicalAdapter = WmiValueConverter.AsBool(p.GetValueOrDefault("PhysicalAdapter")),
        PNPDeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("PNPDeviceID")),
        PowerManagementCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PowerManagementCapabilities")),
        PowerManagementSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("PowerManagementSupported")),
        ProductName = WmiValueConverter.AsString(p.GetValueOrDefault("ProductName")),
        ServiceName = WmiValueConverter.AsString(p.GetValueOrDefault("ServiceName")),
        Speed = WmiValueConverter.AsUInt64(p.GetValueOrDefault("Speed")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        StatusInfo = WmiValueConverter.AsUInt16(p.GetValueOrDefault("StatusInfo")),
        SystemCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemCreationClassName")),
        SystemName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemName")),
        TimeOfLastReset = WmiValueConverter.AsDateTime(p.GetValueOrDefault("TimeOfLastReset")),
    };
}
