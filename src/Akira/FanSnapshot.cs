namespace Akira;

/// <summary>
/// Snapshot of a cooling fan. Maps to Win32_Fan.
/// </summary>
public sealed class FanSnapshot
{
    /// <summary>Whether the fan provides active (true) or passive (false) cooling.</summary>
    public bool? ActiveCooling { get; init; }

    /// <summary>Availability and status of the device.</summary>
    public ushort? Availability { get; init; }

    /// <summary>Short description of the fan.</summary>
    public string? Caption { get; init; }

    /// <summary>Win32 Configuration Manager error code.</summary>
    public uint? ConfigManagerErrorCode { get; init; }

    /// <summary>Whether the device is using a user-defined configuration.</summary>
    public bool? ConfigManagerUserConfig { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Description of the fan.</summary>
    public string? Description { get; init; }

    /// <summary>Desired speed of the fan in revolutions per minute.</summary>
    public ulong? DesiredSpeed { get; init; }

    /// <summary>Unique identifier of the fan.</summary>
    public string? DeviceID { get; init; }

    /// <summary>Whether the error reported in LastErrorCode has been cleared.</summary>
    public bool? ErrorCleared { get; init; }

    /// <summary>Free-form string providing information about the last error.</summary>
    public string? ErrorDescription { get; init; }

    /// <summary>Date and time the fan was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Last error code reported by the logical device.</summary>
    public uint? LastErrorCode { get; init; }

    /// <summary>Name of the fan.</summary>
    public string? Name { get; init; }

    /// <summary>Windows Plug and Play device identifier.</summary>
    public string? PNPDeviceID { get; init; }

    /// <summary>Array of power management capabilities of the device.</summary>
    public ushort[]? PowerManagementCapabilities { get; init; }

    /// <summary>Whether the device supports power management.</summary>
    public bool? PowerManagementSupported { get; init; }

    /// <summary>Current status of the fan.</summary>
    public string? Status { get; init; }

    /// <summary>State of the logical device.</summary>
    public ushort? StatusInfo { get; init; }

    /// <summary>Scoping system's CreationClassName.</summary>
    public string? SystemCreationClassName { get; init; }

    /// <summary>Name of the scoping system.</summary>
    public string? SystemName { get; init; }

    /// <summary>Whether the fan speed can be varied.</summary>
    public bool? VariableSpeed { get; init; }
}
