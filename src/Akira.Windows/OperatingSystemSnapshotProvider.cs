using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="OperatingSystemSnapshot"/>. Queries Win32_OperatingSystem.
/// </summary>
public sealed class OperatingSystemSnapshotProvider : WmiSnapshotProvider<OperatingSystemSnapshot>
{
    /// <inheritdoc />
    public OperatingSystemSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_OperatingSystem";

    /// <inheritdoc />
    protected override OperatingSystemSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        BootDevice = WmiValueConverter.AsString(p.GetValueOrDefault("BootDevice")),
        BuildNumber = WmiValueConverter.AsString(p.GetValueOrDefault("BuildNumber")),
        BuildType = WmiValueConverter.AsString(p.GetValueOrDefault("BuildType")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        CodeSet = WmiValueConverter.AsString(p.GetValueOrDefault("CodeSet")),
        CountryCode = WmiValueConverter.AsString(p.GetValueOrDefault("CountryCode")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        CSCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CSCreationClassName")),
        CSDVersion = WmiValueConverter.AsString(p.GetValueOrDefault("CSDVersion")),
        CSName = WmiValueConverter.AsString(p.GetValueOrDefault("CSName")),
        CurrentTimeZone = WmiValueConverter.AsInt16(p.GetValueOrDefault("CurrentTimeZone")),
        DataExecutionPrevention_Available = WmiValueConverter.AsBool(p.GetValueOrDefault("DataExecutionPrevention_Available")),
        DataExecutionPrevention_32BitApplications = WmiValueConverter.AsBool(p.GetValueOrDefault("DataExecutionPrevention_32BitApplications")),
        DataExecutionPrevention_Drivers = WmiValueConverter.AsBool(p.GetValueOrDefault("DataExecutionPrevention_Drivers")),
        DataExecutionPrevention_SupportPolicy = WmiValueConverter.AsByte(p.GetValueOrDefault("DataExecutionPrevention_SupportPolicy")),
        Debug = WmiValueConverter.AsBool(p.GetValueOrDefault("Debug")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        Distributed = WmiValueConverter.AsBool(p.GetValueOrDefault("Distributed")),
        EncryptionLevel = WmiValueConverter.AsUInt32(p.GetValueOrDefault("EncryptionLevel")),
        ForegroundApplicationBoost = WmiValueConverter.AsByte(p.GetValueOrDefault("ForegroundApplicationBoost")),
        FreePhysicalMemory = WmiValueConverter.AsUInt64(p.GetValueOrDefault("FreePhysicalMemory")),
        FreeSpaceInPagingFiles = WmiValueConverter.AsUInt64(p.GetValueOrDefault("FreeSpaceInPagingFiles")),
        FreeVirtualMemory = WmiValueConverter.AsUInt64(p.GetValueOrDefault("FreeVirtualMemory")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        LargeSystemCache = WmiValueConverter.AsUInt32(p.GetValueOrDefault("LargeSystemCache")),
        LastBootUpTime = WmiValueConverter.AsDateTime(p.GetValueOrDefault("LastBootUpTime")),
        LocalDateTime = WmiValueConverter.AsDateTime(p.GetValueOrDefault("LocalDateTime")),
        Locale = WmiValueConverter.AsString(p.GetValueOrDefault("Locale")),
        Manufacturer = WmiValueConverter.AsString(p.GetValueOrDefault("Manufacturer")),
        MaxNumberOfProcesses = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaxNumberOfProcesses")),
        MaxProcessMemorySize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("MaxProcessMemorySize")),
        MUILanguages = WmiValueConverter.AsStringArray(p.GetValueOrDefault("MUILanguages")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        NumberOfLicensedUsers = WmiValueConverter.AsUInt32(p.GetValueOrDefault("NumberOfLicensedUsers")),
        NumberOfProcesses = WmiValueConverter.AsUInt32(p.GetValueOrDefault("NumberOfProcesses")),
        NumberOfUsers = WmiValueConverter.AsUInt32(p.GetValueOrDefault("NumberOfUsers")),
        OperatingSystemSKU = WmiValueConverter.AsUInt32(p.GetValueOrDefault("OperatingSystemSKU")),
        Organization = WmiValueConverter.AsString(p.GetValueOrDefault("Organization")),
        OSArchitecture = WmiValueConverter.AsString(p.GetValueOrDefault("OSArchitecture")),
        OSLanguage = WmiValueConverter.AsUInt32(p.GetValueOrDefault("OSLanguage")),
        OSProductSuite = WmiValueConverter.AsUInt32(p.GetValueOrDefault("OSProductSuite")),
        OSType = WmiValueConverter.AsUInt16(p.GetValueOrDefault("OSType")),
        OtherTypeDescription = WmiValueConverter.AsString(p.GetValueOrDefault("OtherTypeDescription")),
        PAEEnabled = WmiValueConverter.AsBool(p.GetValueOrDefault("PAEEnabled")),
        PlusProductID = WmiValueConverter.AsString(p.GetValueOrDefault("PlusProductID")),
        PlusVersionNumber = WmiValueConverter.AsString(p.GetValueOrDefault("PlusVersionNumber")),
        PortableOperatingSystem = WmiValueConverter.AsBool(p.GetValueOrDefault("PortableOperatingSystem")),
        Primary = WmiValueConverter.AsBool(p.GetValueOrDefault("Primary")),
        ProductType = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ProductType")),
        QuantumLength = WmiValueConverter.AsByte(p.GetValueOrDefault("QuantumLength")),
        QuantumType = WmiValueConverter.AsByte(p.GetValueOrDefault("QuantumType")),
        RegisteredUser = WmiValueConverter.AsString(p.GetValueOrDefault("RegisteredUser")),
        SerialNumber = WmiValueConverter.AsString(p.GetValueOrDefault("SerialNumber")),
        ServicePackMajorVersion = WmiValueConverter.AsUInt16(p.GetValueOrDefault("ServicePackMajorVersion")),
        ServicePackMinorVersion = WmiValueConverter.AsUInt16(p.GetValueOrDefault("ServicePackMinorVersion")),
        SizeStoredInPagingFiles = WmiValueConverter.AsUInt64(p.GetValueOrDefault("SizeStoredInPagingFiles")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        SuiteMask = WmiValueConverter.AsUInt32(p.GetValueOrDefault("SuiteMask")),
        SystemDevice = WmiValueConverter.AsString(p.GetValueOrDefault("SystemDevice")),
        SystemDirectory = WmiValueConverter.AsString(p.GetValueOrDefault("SystemDirectory")),
        SystemDrive = WmiValueConverter.AsString(p.GetValueOrDefault("SystemDrive")),
        TotalSwapSpaceSize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("TotalSwapSpaceSize")),
        TotalVirtualMemorySize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("TotalVirtualMemorySize")),
        TotalVisibleMemorySize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("TotalVisibleMemorySize")),
        Version = WmiValueConverter.AsString(p.GetValueOrDefault("Version")),
        WindowsDirectory = WmiValueConverter.AsString(p.GetValueOrDefault("WindowsDirectory")),
    };
}
