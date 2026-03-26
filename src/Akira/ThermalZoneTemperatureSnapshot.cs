namespace Akira;

/// <summary>
/// Snapshot of a thermal zone temperature. Maps to MSAcpi_ThermalZoneTemperature.
/// </summary>
public sealed class ThermalZoneTemperatureSnapshot
{
    /// <summary>Whether the thermal zone is active.</summary>
    public bool? Active { get; init; }

    /// <summary>Array of active trip point temperatures.</summary>
    public uint? ActiveTripPoint { get; init; }

    /// <summary>Number of active trip points.</summary>
    public uint? ActiveTripPointCount { get; init; }

    /// <summary>Critical trip point temperature in tenths of degrees Kelvin.</summary>
    public uint? CriticalTripPoint { get; init; }

    /// <summary>Current temperature in tenths of degrees Kelvin.</summary>
    public uint? CurrentTemperature { get; init; }

    /// <summary>WMI instance name identifying the thermal zone.</summary>
    public string? InstanceName { get; init; }

    /// <summary>Passive trip point temperature in tenths of degrees Kelvin.</summary>
    public uint? PassiveTripPoint { get; init; }

    /// <summary>Rate at which the zone should be sampled in tenths of a second.</summary>
    public uint? SamplingPeriod { get; init; }

    /// <summary>First thermal constant for the zone.</summary>
    public uint? ThermalConstant1 { get; init; }

    /// <summary>Second thermal constant for the zone.</summary>
    public uint? ThermalConstant2 { get; init; }

    /// <summary>Thermal information stamp value.</summary>
    public uint? ThermalStamp { get; init; }
}
