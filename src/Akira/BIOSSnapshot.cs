namespace Akira;

/// <summary>
/// Snapshot of the system BIOS. Maps to Win32_BIOS.
/// </summary>
public sealed class BIOSSnapshot
{
    /// <summary>Array of BIOS characteristics supported by the system (SMBIOS Type 0 offset 12h).</summary>
    public ushort[]? BiosCharacteristics { get; init; }

    /// <summary>Array of the complete system BIOS version information.</summary>
    public string[]? BIOSVersion { get; init; }

    /// <summary>Internal identifier for the compiled binary of the BIOS software element.</summary>
    public string? BuildNumber { get; init; }

    /// <summary>Short description of the BIOS.</summary>
    public string? Caption { get; init; }

    /// <summary>Character set or encoding used by the BIOS manufacturer.</summary>
    public string? CodeSet { get; init; }

    /// <summary>Name of the current BIOS language.</summary>
    public string? CurrentLanguage { get; init; }

    /// <summary>Description of the BIOS.</summary>
    public string? Description { get; init; }

    /// <summary>Major version of the embedded controller firmware.</summary>
    public byte? EmbeddedControllerMajorVersion { get; init; }

    /// <summary>Minor version of the embedded controller firmware.</summary>
    public byte? EmbeddedControllerMinorVersion { get; init; }

    /// <summary>Manufacturer's identifier for the BIOS.</summary>
    public string? IdentificationCode { get; init; }

    /// <summary>Number of installable languages available for the BIOS.</summary>
    public ushort? InstallableLanguages { get; init; }

    /// <summary>Date and time the BIOS was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Language edition of the BIOS firmware.</summary>
    public string? LanguageEdition { get; init; }

    /// <summary>Array of installable language names available for the BIOS.</summary>
    public string[]? ListOfLanguages { get; init; }

    /// <summary>Manufacturer of the BIOS.</summary>
    public string? Manufacturer { get; init; }

    /// <summary>Name used to identify the BIOS.</summary>
    public string? Name { get; init; }

    /// <summary>Records manufacturer and operating system type for a BIOS targeted for a different OS.</summary>
    public string? OtherTargetOS { get; init; }

    /// <summary>Whether this is the primary BIOS of the computer system.</summary>
    public bool? PrimaryBIOS { get; init; }

    /// <summary>Release date of the BIOS in UTC.</summary>
    public string? ReleaseDate { get; init; }

    /// <summary>Assigned serial number of the BIOS.</summary>
    public string? SerialNumber { get; init; }

    /// <summary>BIOS version as reported by SMBIOS.</summary>
    public string? SMBIOSBIOSVersion { get; init; }

    /// <summary>SMBIOS major version number.</summary>
    public ushort? SMBIOSMajorVersion { get; init; }

    /// <summary>SMBIOS minor version number.</summary>
    public ushort? SMBIOSMinorVersion { get; init; }

    /// <summary>Whether the SMBIOS is available on the computer system.</summary>
    public bool? SMBIOSPresent { get; init; }

    /// <summary>Identifier for the BIOS software element.</summary>
    public string? SoftwareElementID { get; init; }

    /// <summary>State of the BIOS software element (e.g. 0 = Deployable, 1 = Installable).</summary>
    public ushort? SoftwareElementState { get; init; }

    /// <summary>Current status of the BIOS.</summary>
    public string? Status { get; init; }

    /// <summary>Major version of the system BIOS.</summary>
    public byte? SystemBiosMajorVersion { get; init; }

    /// <summary>Minor version of the system BIOS.</summary>
    public byte? SystemBiosMinorVersion { get; init; }

    /// <summary>Target operating system identifier.</summary>
    public ushort? TargetOperatingSystem { get; init; }

    /// <summary>Version of the BIOS (includes both major and minor version numbers).</summary>
    public string? Version { get; init; }
}
