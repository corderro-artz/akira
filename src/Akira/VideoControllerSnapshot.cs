namespace Akira;

/// <summary>
/// Snapshot of a video controller (GPU). Maps to Win32_VideoController.
/// </summary>
public sealed class VideoControllerSnapshot
{
    /// <summary>Array of accelerator capabilities.</summary>
    public ushort[]? AcceleratorCapabilities { get; init; }

    /// <summary>Name of the adapter's compatible display adapter.</summary>
    public string? AdapterCompatibility { get; init; }

    /// <summary>DAC type (e.g. "Integrated RAMDAC").</summary>
    public string? AdapterDACType { get; init; }

    /// <summary>Memory size of the video adapter in bytes.</summary>
    public uint? AdapterRAM { get; init; }

    /// <summary>Availability and status of the device.</summary>
    public ushort? Availability { get; init; }

    /// <summary>Descriptions of the accelerator capabilities.</summary>
    public string[]? CapabilityDescriptions { get; init; }

    /// <summary>Short description of the video controller.</summary>
    public string? Caption { get; init; }

    /// <summary>Number of color table entries.</summary>
    public uint? ColorTableEntries { get; init; }

    /// <summary>Win32 Configuration Manager error code.</summary>
    public uint? ConfigManagerErrorCode { get; init; }

    /// <summary>Whether the device uses a user-defined configuration.</summary>
    public bool? ConfigManagerUserConfig { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Current number of bits used for each pixel.</summary>
    public uint? CurrentBitsPerPixel { get; init; }

    /// <summary>Current horizontal resolution in pixels.</summary>
    public uint? CurrentHorizontalResolution { get; init; }

    /// <summary>Number of colors supported at the current resolution.</summary>
    public ulong? CurrentNumberOfColors { get; init; }

    /// <summary>Number of columns for this video controller.</summary>
    public uint? CurrentNumberOfColumns { get; init; }

    /// <summary>Number of rows for this video controller.</summary>
    public uint? CurrentNumberOfRows { get; init; }

    /// <summary>Frequency at which the video controller refreshes the screen.</summary>
    public uint? CurrentRefreshRate { get; init; }

    /// <summary>Current scan mode (1 = Other, 2 = Unknown, 3 = Interlaced, 4 = Non-interlaced).</summary>
    public ushort? CurrentScanMode { get; init; }

    /// <summary>Current vertical resolution in pixels.</summary>
    public uint? CurrentVerticalResolution { get; init; }

    /// <summary>Description of the video controller.</summary>
    public string? Description { get; init; }

    /// <summary>Unique identifier of the device.</summary>
    public string? DeviceID { get; init; }

    /// <summary>Number of device-specific pens.</summary>
    public uint? DeviceSpecificPens { get; init; }

    /// <summary>Dither type of the video controller.</summary>
    public uint? DitherType { get; init; }

    /// <summary>Last modification date of the driver.</summary>
    public DateTime? DriverDate { get; init; }

    /// <summary>Version of the video driver.</summary>
    public string? DriverVersion { get; init; }

    /// <summary>Whether the error reported in LastErrorCode has been cleared.</summary>
    public bool? ErrorCleared { get; init; }

    /// <summary>Free-form string about the last error.</summary>
    public string? ErrorDescription { get; init; }

    /// <summary>Image Color Management intent.</summary>
    public uint? ICMIntent { get; init; }

    /// <summary>Image Color Management method.</summary>
    public uint? ICMMethod { get; init; }

    /// <summary>Path of the INF file for this device.</summary>
    public string? InfFilename { get; init; }

    /// <summary>Section of the INF file used for this device.</summary>
    public string? InfSection { get; init; }

    /// <summary>Date and time the object was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Name of the installed display driver files.</summary>
    public string? InstalledDisplayDrivers { get; init; }

    /// <summary>Last error code reported by the logical device.</summary>
    public uint? LastErrorCode { get; init; }

    /// <summary>Maximum amount of memory supported in bytes.</summary>
    public uint? MaxMemorySupported { get; init; }

    /// <summary>Maximum number of directly addressable entities.</summary>
    public uint? MaxNumberControlled { get; init; }

    /// <summary>Maximum refresh rate of the video controller in Hz.</summary>
    public uint? MaxRefreshRate { get; init; }

    /// <summary>Minimum refresh rate of the video controller in Hz.</summary>
    public uint? MinRefreshRate { get; init; }

    /// <summary>Whether the video controller supports monochrome only.</summary>
    public bool? Monochrome { get; init; }

    /// <summary>Label by which the object is known.</summary>
    public string? Name { get; init; }

    /// <summary>Current number of color planes.</summary>
    public ushort? NumberOfColorPlanes { get; init; }

    /// <summary>Number of video pages.</summary>
    public uint? NumberOfVideoPages { get; init; }

    /// <summary>Windows Plug and Play device identifier.</summary>
    public string? PNPDeviceID { get; init; }

    /// <summary>Array of power-related capabilities.</summary>
    public ushort[]? PowerManagementCapabilities { get; init; }

    /// <summary>Whether the device can be power-managed.</summary>
    public bool? PowerManagementSupported { get; init; }

    /// <summary>Protocol supported for controller access.</summary>
    public ushort? ProtocolSupported { get; init; }

    /// <summary>Number of reserved system palette entries.</summary>
    public uint? ReservedSystemPaletteEntries { get; init; }

    /// <summary>Specification version number.</summary>
    public uint? SpecificationVersion { get; init; }

    /// <summary>Current status of the object.</summary>
    public string? Status { get; init; }

    /// <summary>State of the logical device.</summary>
    public ushort? StatusInfo { get; init; }

    /// <summary>CreationClassName of the scoping computer system.</summary>
    public string? SystemCreationClassName { get; init; }

    /// <summary>Name of the scoping system.</summary>
    public string? SystemName { get; init; }

    /// <summary>Current number of system palette entries.</summary>
    public uint? SystemPaletteEntries { get; init; }

    /// <summary>Date and time of the last controller reset.</summary>
    public DateTime? TimeOfLastReset { get; init; }

    /// <summary>Video architecture type.</summary>
    public ushort? VideoArchitecture { get; init; }

    /// <summary>Type of video memory.</summary>
    public ushort? VideoMemoryType { get; init; }

    /// <summary>Current video mode.</summary>
    public ushort? VideoMode { get; init; }

    /// <summary>Current resolution and color description.</summary>
    public string? VideoModeDescription { get; init; }

    /// <summary>Free-form string describing the video processor.</summary>
    public string? VideoProcessor { get; init; }
}
