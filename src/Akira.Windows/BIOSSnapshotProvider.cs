using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="BIOSSnapshot"/>. Queries Win32_BIOS.
/// </summary>
public sealed class BIOSSnapshotProvider : WmiSnapshotProvider<BIOSSnapshot>
{
    /// <inheritdoc />
    public BIOSSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_BIOS";

    /// <inheritdoc />
    protected override BIOSSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        BiosCharacteristics = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("BiosCharacteristics")),
        BIOSVersion = WmiValueConverter.AsStringArray(p.GetValueOrDefault("BIOSVersion")),
        BuildNumber = WmiValueConverter.AsString(p.GetValueOrDefault("BuildNumber")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        CodeSet = WmiValueConverter.AsString(p.GetValueOrDefault("CodeSet")),
        CurrentLanguage = WmiValueConverter.AsString(p.GetValueOrDefault("CurrentLanguage")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        EmbeddedControllerMajorVersion = WmiValueConverter.AsByte(p.GetValueOrDefault("EmbeddedControllerMajorVersion")),
        EmbeddedControllerMinorVersion = WmiValueConverter.AsByte(p.GetValueOrDefault("EmbeddedControllerMinorVersion")),
        IdentificationCode = WmiValueConverter.AsString(p.GetValueOrDefault("IdentificationCode")),
        InstallableLanguages = WmiValueConverter.AsUInt16(p.GetValueOrDefault("InstallableLanguages")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        LanguageEdition = WmiValueConverter.AsString(p.GetValueOrDefault("LanguageEdition")),
        ListOfLanguages = WmiValueConverter.AsStringArray(p.GetValueOrDefault("ListOfLanguages")),
        Manufacturer = WmiValueConverter.AsString(p.GetValueOrDefault("Manufacturer")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        OtherTargetOS = WmiValueConverter.AsString(p.GetValueOrDefault("OtherTargetOS")),
        PrimaryBIOS = WmiValueConverter.AsBool(p.GetValueOrDefault("PrimaryBIOS")),
        ReleaseDate = WmiValueConverter.AsString(p.GetValueOrDefault("ReleaseDate")),
        SerialNumber = WmiValueConverter.AsString(p.GetValueOrDefault("SerialNumber")),
        SMBIOSBIOSVersion = WmiValueConverter.AsString(p.GetValueOrDefault("SMBIOSBIOSVersion")),
        SMBIOSMajorVersion = WmiValueConverter.AsUInt16(p.GetValueOrDefault("SMBIOSMajorVersion")),
        SMBIOSMinorVersion = WmiValueConverter.AsUInt16(p.GetValueOrDefault("SMBIOSMinorVersion")),
        SMBIOSPresent = WmiValueConverter.AsBool(p.GetValueOrDefault("SMBIOSPresent")),
        SoftwareElementID = WmiValueConverter.AsString(p.GetValueOrDefault("SoftwareElementID")),
        SoftwareElementState = WmiValueConverter.AsUInt16(p.GetValueOrDefault("SoftwareElementState")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        SystemBiosMajorVersion = WmiValueConverter.AsByte(p.GetValueOrDefault("SystemBiosMajorVersion")),
        SystemBiosMinorVersion = WmiValueConverter.AsByte(p.GetValueOrDefault("SystemBiosMinorVersion")),
        TargetOperatingSystem = WmiValueConverter.AsUInt16(p.GetValueOrDefault("TargetOperatingSystem")),
        Version = WmiValueConverter.AsString(p.GetValueOrDefault("Version")),
    };
}
