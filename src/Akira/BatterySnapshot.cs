namespace Akira;

/// <summary>
/// Snapshot of a battery. Maps to Win32_Battery.
/// </summary>
public sealed class BatterySnapshot
{
    /// <summary>Availability and status of the device.</summary>
    public ushort? Availability { get; init; }

    /// <summary>Status of the battery (1 = Discharging, 2 = AC, 3 = Fully Charged, etc.).</summary>
    public ushort? BatteryStatus { get; init; }

    /// <summary>Short description of the battery.</summary>
    public string? Caption { get; init; }

    /// <summary>Chemistry of the battery (1 = Other, 2 = Unknown, 3 = Lead Acid, 4 = NiCd, etc.).</summary>
    public ushort? Chemistry { get; init; }

    /// <summary>Win32 Configuration Manager error code.</summary>
    public uint? ConfigManagerErrorCode { get; init; }

    /// <summary>Whether the device is using a user-defined configuration.</summary>
    public bool? ConfigManagerUserConfig { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Description of the battery.</summary>
    public string? Description { get; init; }

    /// <summary>Design capacity of the battery in milliwatt-hours.</summary>
    public uint? DesignCapacity { get; init; }

    /// <summary>Design voltage of the battery in millivolts.</summary>
    public ulong? DesignVoltage { get; init; }

    /// <summary>Unique identifier of the battery.</summary>
    public string? DeviceID { get; init; }

    /// <summary>Whether the error reported in LastErrorCode has been cleared.</summary>
    public bool? ErrorCleared { get; init; }

    /// <summary>Free-form string providing information about the last error.</summary>
    public string? ErrorDescription { get; init; }

    /// <summary>Estimated percentage of charge remaining.</summary>
    public ushort? EstimatedChargeRemaining { get; init; }

    /// <summary>Estimated time in minutes to complete charging or remaining battery life.</summary>
    public uint? EstimatedRunTime { get; init; }

    /// <summary>Expected life of the battery in minutes when fully charged.</summary>
    public uint? ExpectedLife { get; init; }

    /// <summary>Full charge capacity of the battery in milliwatt-hours.</summary>
    public uint? FullChargeCapacity { get; init; }

    /// <summary>Date and time the battery was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Last error code reported by the logical device.</summary>
    public uint? LastErrorCode { get; init; }

    /// <summary>Maximum time in minutes to fully charge the battery.</summary>
    public uint? MaxRechargeTime { get; init; }

    /// <summary>Name of the battery.</summary>
    public string? Name { get; init; }

    /// <summary>Windows Plug and Play device identifier.</summary>
    public string? PNPDeviceID { get; init; }

    /// <summary>Array of power management capabilities of the device.</summary>
    public ushort[]? PowerManagementCapabilities { get; init; }

    /// <summary>Whether the device supports power management.</summary>
    public bool? PowerManagementSupported { get; init; }

    /// <summary>Smart Battery Data Specification version supported.</summary>
    public string? SmartBatteryVersion { get; init; }

    /// <summary>Current status of the battery.</summary>
    public string? Status { get; init; }

    /// <summary>State of the logical device.</summary>
    public ushort? StatusInfo { get; init; }

    /// <summary>Scoping system's CreationClassName.</summary>
    public string? SystemCreationClassName { get; init; }

    /// <summary>Name of the scoping system.</summary>
    public string? SystemName { get; init; }

    /// <summary>Elapsed time in seconds since the computer was last switched to battery power.</summary>
    public uint? TimeOnBattery { get; init; }

    /// <summary>Remaining time in minutes to charge the battery fully.</summary>
    public uint? TimeToFullCharge { get; init; }
}
