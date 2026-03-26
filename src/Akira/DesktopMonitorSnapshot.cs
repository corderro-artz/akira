namespace Vaporsoft.Akira;

/// <summary>
/// Snapshot of a desktop monitor. Maps to Win32_DesktopMonitor.
/// </summary>
public sealed class DesktopMonitorSnapshot
{
    /// <summary>Availability and status of the device.</summary>
    public ushort? Availability { get; init; }

    /// <summary>Monitor bandwidth in MHz.</summary>
    public uint? Bandwidth { get; init; }

    /// <summary>Short description of the monitor.</summary>
    public string? Caption { get; init; }

    /// <summary>Win32 Configuration Manager error code.</summary>
    public uint? ConfigManagerErrorCode { get; init; }

    /// <summary>Whether the device uses a user-defined configuration.</summary>
    public bool? ConfigManagerUserConfig { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Description of the monitor.</summary>
    public string? Description { get; init; }

    /// <summary>Unique identifier of the monitor.</summary>
    public string? DeviceID { get; init; }

    /// <summary>Type of display monitor (1 = Other, 2 = Unknown, 3 = CRT, 4 = LCD).</summary>
    public ushort? DisplayType { get; init; }

    /// <summary>Whether the error reported in LastErrorCode has been cleared.</summary>
    public bool? ErrorCleared { get; init; }

    /// <summary>Free-form string about the last error.</summary>
    public string? ErrorDescription { get; init; }

    /// <summary>Date and time the object was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Whether the monitor is locked (preventing user input).</summary>
    public bool? IsLocked { get; init; }

    /// <summary>Last error code reported by the logical device.</summary>
    public uint? LastErrorCode { get; init; }

    /// <summary>Name of the monitor manufacturer.</summary>
    public string? MonitorManufacturer { get; init; }

    /// <summary>Type of monitor.</summary>
    public string? MonitorType { get; init; }

    /// <summary>Label by which the object is known.</summary>
    public string? Name { get; init; }

    /// <summary>Horizontal resolution of the monitor in pixels per logical inch.</summary>
    public uint? PixelsPerXLogicalInch { get; init; }

    /// <summary>Vertical resolution of the monitor in pixels per logical inch.</summary>
    public uint? PixelsPerYLogicalInch { get; init; }

    /// <summary>Windows Plug and Play device identifier.</summary>
    public string? PNPDeviceID { get; init; }

    /// <summary>Array of power-related capabilities.</summary>
    public ushort[]? PowerManagementCapabilities { get; init; }

    /// <summary>Whether the device can be power-managed.</summary>
    public bool? PowerManagementSupported { get; init; }

    /// <summary>Logical height of the display in screen coordinates.</summary>
    public uint? ScreenHeight { get; init; }

    /// <summary>Logical width of the display in screen coordinates.</summary>
    public uint? ScreenWidth { get; init; }

    /// <summary>Current status of the object.</summary>
    public string? Status { get; init; }

    /// <summary>State of the logical device.</summary>
    public ushort? StatusInfo { get; init; }

    /// <summary>CreationClassName of the scoping computer system.</summary>
    public string? SystemCreationClassName { get; init; }

    /// <summary>Name of the scoping system.</summary>
    public string? SystemName { get; init; }
}
