using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="ThermalZoneTemperatureSnapshot"/>. Queries MSAcpi_ThermalZoneTemperature from root\WMI.
/// </summary>
public sealed class ThermalZoneTemperatureSnapshotProvider : WmiCollectionSnapshotProvider<ThermalZoneTemperatureSnapshot>
{
    /// <inheritdoc />
    public ThermalZoneTemperatureSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiNamespace => @"root\WMI";

    /// <inheritdoc />
    protected override string WmiClassName => "MSAcpi_ThermalZoneTemperature";

    /// <inheritdoc />
    protected override ThermalZoneTemperatureSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Active = WmiValueConverter.AsBool(p.GetValueOrDefault("Active")),
        ActiveTripPoint = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ActiveTripPoint")),
        ActiveTripPointCount = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ActiveTripPointCount")),
        CriticalTripPoint = WmiValueConverter.AsUInt32(p.GetValueOrDefault("CriticalTripPoint")),
        CurrentTemperature = WmiValueConverter.AsUInt32(p.GetValueOrDefault("CurrentTemperature")),
        InstanceName = WmiValueConverter.AsString(p.GetValueOrDefault("InstanceName")),
        PassiveTripPoint = WmiValueConverter.AsUInt32(p.GetValueOrDefault("PassiveTripPoint")),
        SamplingPeriod = WmiValueConverter.AsUInt32(p.GetValueOrDefault("SamplingPeriod")),
        ThermalConstant1 = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ThermalConstant1")),
        ThermalConstant2 = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ThermalConstant2")),
        ThermalStamp = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ThermalStamp")),
    };
}
