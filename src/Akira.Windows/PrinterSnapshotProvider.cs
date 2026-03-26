using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="PrinterSnapshot"/>. Queries Win32_Printer.
/// </summary>
public sealed class PrinterSnapshotProvider : WmiCollectionSnapshotProvider<PrinterSnapshot>
{
    /// <inheritdoc />
    public PrinterSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_Printer";

    /// <inheritdoc />
    protected override PrinterSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Attributes = WmiValueConverter.AsUInt32(p.GetValueOrDefault("Attributes")),
        Availability = WmiValueConverter.AsUInt16(p.GetValueOrDefault("Availability")),
        AvailableJobSheets = WmiValueConverter.AsStringArray(p.GetValueOrDefault("AvailableJobSheets")),
        AveragePagesPerMinute = WmiValueConverter.AsUInt32(p.GetValueOrDefault("AveragePagesPerMinute")),
        Capabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("Capabilities")),
        CapabilityDescriptions = WmiValueConverter.AsStringArray(p.GetValueOrDefault("CapabilityDescriptions")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        CharSetsSupported = WmiValueConverter.AsStringArray(p.GetValueOrDefault("CharSetsSupported")),
        Comment = WmiValueConverter.AsString(p.GetValueOrDefault("Comment")),
        ConfigManagerErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ConfigManagerErrorCode")),
        ConfigManagerUserConfig = WmiValueConverter.AsBool(p.GetValueOrDefault("ConfigManagerUserConfig")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        CurrentCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("CurrentCapabilities")),
        CurrentCharSet = WmiValueConverter.AsString(p.GetValueOrDefault("CurrentCharSet")),
        CurrentLanguage = WmiValueConverter.AsUInt16(p.GetValueOrDefault("CurrentLanguage")),
        CurrentMimeType = WmiValueConverter.AsString(p.GetValueOrDefault("CurrentMimeType")),
        CurrentNaturalLanguage = WmiValueConverter.AsString(p.GetValueOrDefault("CurrentNaturalLanguage")),
        CurrentPaperType = WmiValueConverter.AsString(p.GetValueOrDefault("CurrentPaperType")),
        Default = WmiValueConverter.AsBool(p.GetValueOrDefault("Default")),
        DefaultCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("DefaultCapabilities")),
        DefaultCopies = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DefaultCopies")),
        DefaultLanguage = WmiValueConverter.AsUInt16(p.GetValueOrDefault("DefaultLanguage")),
        DefaultMimeType = WmiValueConverter.AsString(p.GetValueOrDefault("DefaultMimeType")),
        DefaultNumberUp = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DefaultNumberUp")),
        DefaultPaperType = WmiValueConverter.AsString(p.GetValueOrDefault("DefaultPaperType")),
        DefaultPriority = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DefaultPriority")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DetectedErrorState = WmiValueConverter.AsUInt16(p.GetValueOrDefault("DetectedErrorState")),
        DeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("DeviceID")),
        Direct = WmiValueConverter.AsBool(p.GetValueOrDefault("Direct")),
        DoCompleteFirst = WmiValueConverter.AsBool(p.GetValueOrDefault("DoCompleteFirst")),
        DriverName = WmiValueConverter.AsString(p.GetValueOrDefault("DriverName")),
        EnableBIDI = WmiValueConverter.AsBool(p.GetValueOrDefault("EnableBIDI")),
        EnableDevQueryPrint = WmiValueConverter.AsBool(p.GetValueOrDefault("EnableDevQueryPrint")),
        ErrorCleared = WmiValueConverter.AsBool(p.GetValueOrDefault("ErrorCleared")),
        ErrorDescription = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorDescription")),
        ErrorInformation = WmiValueConverter.AsStringArray(p.GetValueOrDefault("ErrorInformation")),
        ExtendedDetectedErrorState = WmiValueConverter.AsUInt16(p.GetValueOrDefault("ExtendedDetectedErrorState")),
        ExtendedPrinterStatus = WmiValueConverter.AsUInt16(p.GetValueOrDefault("ExtendedPrinterStatus")),
        Hidden = WmiValueConverter.AsBool(p.GetValueOrDefault("Hidden")),
        HorizontalResolution = WmiValueConverter.AsUInt32(p.GetValueOrDefault("HorizontalResolution")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        JobCountSinceLastReset = WmiValueConverter.AsUInt32(p.GetValueOrDefault("JobCountSinceLastReset")),
        KeepPrintedJobs = WmiValueConverter.AsBool(p.GetValueOrDefault("KeepPrintedJobs")),
        LanguagesSupported = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("LanguagesSupported")),
        LastErrorCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("LastErrorCode")),
        Local = WmiValueConverter.AsBool(p.GetValueOrDefault("Local")),
        Location = WmiValueConverter.AsString(p.GetValueOrDefault("Location")),
        MarkingTechnology = WmiValueConverter.AsUInt16(p.GetValueOrDefault("MarkingTechnology")),
        MaxCopies = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaxCopies")),
        MaxNumberUp = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaxNumberUp")),
        MaxSizeSupported = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaxSizeSupported")),
        MimeTypesSupported = WmiValueConverter.AsStringArray(p.GetValueOrDefault("MimeTypesSupported")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        NaturalLanguagesSupported = WmiValueConverter.AsStringArray(p.GetValueOrDefault("NaturalLanguagesSupported")),
        Network = WmiValueConverter.AsBool(p.GetValueOrDefault("Network")),
        PaperSizesSupported = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PaperSizesSupported")),
        PaperTypesAvailable = WmiValueConverter.AsStringArray(p.GetValueOrDefault("PaperTypesAvailable")),
        Parameters = WmiValueConverter.AsString(p.GetValueOrDefault("Parameters")),
        PNPDeviceID = WmiValueConverter.AsString(p.GetValueOrDefault("PNPDeviceID")),
        PortName = WmiValueConverter.AsString(p.GetValueOrDefault("PortName")),
        PowerManagementCapabilities = WmiValueConverter.AsUInt16Array(p.GetValueOrDefault("PowerManagementCapabilities")),
        PowerManagementSupported = WmiValueConverter.AsBool(p.GetValueOrDefault("PowerManagementSupported")),
        PrinterPaperNames = WmiValueConverter.AsStringArray(p.GetValueOrDefault("PrinterPaperNames")),
        PrinterStatus = WmiValueConverter.AsUInt16(p.GetValueOrDefault("PrinterStatus")),
        PrintJobDataType = WmiValueConverter.AsString(p.GetValueOrDefault("PrintJobDataType")),
        PrintProcessor = WmiValueConverter.AsString(p.GetValueOrDefault("PrintProcessor")),
        Priority = WmiValueConverter.AsUInt32(p.GetValueOrDefault("Priority")),
        Published = WmiValueConverter.AsBool(p.GetValueOrDefault("Published")),
        Queued = WmiValueConverter.AsBool(p.GetValueOrDefault("Queued")),
        RawOnly = WmiValueConverter.AsBool(p.GetValueOrDefault("RawOnly")),
        SeparatorFile = WmiValueConverter.AsString(p.GetValueOrDefault("SeparatorFile")),
        ServerName = WmiValueConverter.AsString(p.GetValueOrDefault("ServerName")),
        Shared = WmiValueConverter.AsBool(p.GetValueOrDefault("Shared")),
        ShareName = WmiValueConverter.AsString(p.GetValueOrDefault("ShareName")),
        StartTime = WmiValueConverter.AsString(p.GetValueOrDefault("StartTime")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        StatusInfo = WmiValueConverter.AsUInt16(p.GetValueOrDefault("StatusInfo")),
        SystemCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemCreationClassName")),
        SystemName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemName")),
        TimeOfLastReset = WmiValueConverter.AsString(p.GetValueOrDefault("TimeOfLastReset")),
        UntilTime = WmiValueConverter.AsString(p.GetValueOrDefault("UntilTime")),
        VerticalResolution = WmiValueConverter.AsUInt32(p.GetValueOrDefault("VerticalResolution")),
        WorkOffline = WmiValueConverter.AsBool(p.GetValueOrDefault("WorkOffline")),
    };
}
