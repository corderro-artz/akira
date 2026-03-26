namespace Akira;

/// <summary>
/// Snapshot of a sound device. Maps to Win32_SoundDevice.
/// </summary>
public sealed class SoundDeviceSnapshot
{
    /// <summary>Availability and status of the device.</summary>
    public ushort? Availability { get; init; }

    /// <summary>Short description of the sound device.</summary>
    public string? Caption { get; init; }

    /// <summary>Win32 Configuration Manager error code.</summary>
    public uint? ConfigManagerErrorCode { get; init; }

    /// <summary>Whether the device is using a user-defined configuration.</summary>
    public bool? ConfigManagerUserConfig { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Description of the sound device.</summary>
    public string? Description { get; init; }

    /// <summary>Unique identifier of the sound device.</summary>
    public string? DeviceID { get; init; }

    /// <summary>Size in kilobytes of the DMA buffer.</summary>
    public ushort? DMABufferSize { get; init; }

    /// <summary>Whether the error reported in LastErrorCode has been cleared.</summary>
    public bool? ErrorCleared { get; init; }

    /// <summary>Free-form string providing information about the last error.</summary>
    public string? ErrorDescription { get; init; }

    /// <summary>Date and time the sound device was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Last error code reported by the logical device.</summary>
    public uint? LastErrorCode { get; init; }

    /// <summary>Manufacturer of the sound device.</summary>
    public string? Manufacturer { get; init; }

    /// <summary>MPU-401 I/O address used by the sound device.</summary>
    public uint? MPU401Address { get; init; }

    /// <summary>Name of the sound device.</summary>
    public string? Name { get; init; }

    /// <summary>Windows Plug and Play device identifier.</summary>
    public string? PNPDeviceID { get; init; }

    /// <summary>Array of power management capabilities of the device.</summary>
    public ushort[]? PowerManagementCapabilities { get; init; }

    /// <summary>Whether the device supports power management.</summary>
    public bool? PowerManagementSupported { get; init; }

    /// <summary>Product name of the sound device.</summary>
    public string? ProductName { get; init; }

    /// <summary>Current status of the sound device.</summary>
    public string? Status { get; init; }

    /// <summary>State of the logical device.</summary>
    public ushort? StatusInfo { get; init; }

    /// <summary>Scoping system's CreationClassName.</summary>
    public string? SystemCreationClassName { get; init; }

    /// <summary>Name of the scoping system.</summary>
    public string? SystemName { get; init; }
}
