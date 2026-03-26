namespace Vaporsoft.Akira;

/// <summary>
/// Snapshot of a printer. Maps to Win32_Printer.
/// </summary>
public sealed class PrinterSnapshot
{
    /// <summary>Printer configuration attributes (bitmap).</summary>
    public uint? Attributes { get; init; }

    /// <summary>Availability and status of the device.</summary>
    public ushort? Availability { get; init; }

    /// <summary>Array of available job sheet names.</summary>
    public string[]? AvailableJobSheets { get; init; }

    /// <summary>Average number of pages per minute the printer can produce.</summary>
    public uint? AveragePagesPerMinute { get; init; }

    /// <summary>Array of printer capabilities (e.g. 1 = Unknown, 2 = Other, 3 = Color Printing).</summary>
    public ushort[]? Capabilities { get; init; }

    /// <summary>Array of descriptions for the corresponding Capabilities entries.</summary>
    public string[]? CapabilityDescriptions { get; init; }

    /// <summary>Short description of the printer.</summary>
    public string? Caption { get; init; }

    /// <summary>Array of character sets supported by the printer.</summary>
    public string[]? CharSetsSupported { get; init; }

    /// <summary>Comment for the printer.</summary>
    public string? Comment { get; init; }

    /// <summary>Win32 Configuration Manager error code.</summary>
    public uint? ConfigManagerErrorCode { get; init; }

    /// <summary>Whether the device is using a user-defined configuration.</summary>
    public bool? ConfigManagerUserConfig { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Array of current printer capabilities being used.</summary>
    public ushort[]? CurrentCapabilities { get; init; }

    /// <summary>Current character set being used.</summary>
    public string? CurrentCharSet { get; init; }

    /// <summary>Current printer language being used.</summary>
    public ushort? CurrentLanguage { get; init; }

    /// <summary>Current MIME type being used.</summary>
    public string? CurrentMimeType { get; init; }

    /// <summary>Current natural language of the printer.</summary>
    public string? CurrentNaturalLanguage { get; init; }

    /// <summary>Current paper type in use.</summary>
    public string? CurrentPaperType { get; init; }

    /// <summary>Whether this is the default printer.</summary>
    public bool? Default { get; init; }

    /// <summary>Array of default printer capabilities.</summary>
    public ushort[]? DefaultCapabilities { get; init; }

    /// <summary>Default number of copies per print job.</summary>
    public uint? DefaultCopies { get; init; }

    /// <summary>Default printer language.</summary>
    public ushort? DefaultLanguage { get; init; }

    /// <summary>Default MIME type for the printer.</summary>
    public string? DefaultMimeType { get; init; }

    /// <summary>Default number of logical pages printed per physical page (N-up).</summary>
    public uint? DefaultNumberUp { get; init; }

    /// <summary>Default paper type for the printer.</summary>
    public string? DefaultPaperType { get; init; }

    /// <summary>Default priority for print jobs on the printer.</summary>
    public uint? DefaultPriority { get; init; }

    /// <summary>Description of the printer.</summary>
    public string? Description { get; init; }

    /// <summary>Detected error state (0 = Unknown, 1 = Other, 2 = No Error, etc.).</summary>
    public ushort? DetectedErrorState { get; init; }

    /// <summary>Unique identifier of the printer.</summary>
    public string? DeviceID { get; init; }

    /// <summary>Whether the printer is directly connected to the computer.</summary>
    public bool? Direct { get; init; }

    /// <summary>Whether the spooler favors jobs that have completed spooling.</summary>
    public bool? DoCompleteFirst { get; init; }

    /// <summary>Name of the printer driver.</summary>
    public string? DriverName { get; init; }

    /// <summary>Whether bi-directional communication with the printer is enabled.</summary>
    public bool? EnableBIDI { get; init; }

    /// <summary>Whether the device query-based mechanism is enabled for printing.</summary>
    public bool? EnableDevQueryPrint { get; init; }

    /// <summary>Whether the error reported in LastErrorCode has been cleared.</summary>
    public bool? ErrorCleared { get; init; }

    /// <summary>Free-form string providing information about the last error.</summary>
    public string? ErrorDescription { get; init; }

    /// <summary>Array of additional error information.</summary>
    public string[]? ErrorInformation { get; init; }

    /// <summary>Extended detected error state.</summary>
    public ushort? ExtendedDetectedErrorState { get; init; }

    /// <summary>Extended printer status.</summary>
    public ushort? ExtendedPrinterStatus { get; init; }

    /// <summary>Whether the printer is hidden from network users.</summary>
    public bool? Hidden { get; init; }

    /// <summary>Horizontal resolution of the printer in pixels per inch.</summary>
    public uint? HorizontalResolution { get; init; }

    /// <summary>Date and time the printer was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Number of print jobs since the printer was last reset.</summary>
    public uint? JobCountSinceLastReset { get; init; }

    /// <summary>Whether the printer retains completed print jobs in the queue.</summary>
    public bool? KeepPrintedJobs { get; init; }

    /// <summary>Array of printer languages or document formats supported.</summary>
    public ushort[]? LanguagesSupported { get; init; }

    /// <summary>Last error code reported by the logical device.</summary>
    public uint? LastErrorCode { get; init; }

    /// <summary>Whether the printer is a local (true) or network (false) printer.</summary>
    public bool? Local { get; init; }

    /// <summary>Physical location of the printer.</summary>
    public string? Location { get; init; }

    /// <summary>Marking technology the printer uses (e.g. 1 = Other, 4 = Laser, 8 = InkJet).</summary>
    public ushort? MarkingTechnology { get; init; }

    /// <summary>Maximum number of copies the printer can produce per job.</summary>
    public uint? MaxCopies { get; init; }

    /// <summary>Maximum number of logical pages per physical page (N-up).</summary>
    public uint? MaxNumberUp { get; init; }

    /// <summary>Maximum size of a print job the printer can accept in kilobytes.</summary>
    public uint? MaxSizeSupported { get; init; }

    /// <summary>Array of MIME types supported by the printer.</summary>
    public string[]? MimeTypesSupported { get; init; }

    /// <summary>Name of the printer.</summary>
    public string? Name { get; init; }

    /// <summary>Array of natural languages supported by the printer.</summary>
    public string[]? NaturalLanguagesSupported { get; init; }

    /// <summary>Whether the printer is a network printer.</summary>
    public bool? Network { get; init; }

    /// <summary>Array of paper sizes supported (e.g. 1 = Letter, 5 = Legal, 9 = A4).</summary>
    public ushort[]? PaperSizesSupported { get; init; }

    /// <summary>Array of paper types available on the printer.</summary>
    public string[]? PaperTypesAvailable { get; init; }

    /// <summary>Optional printer parameters.</summary>
    public string? Parameters { get; init; }

    /// <summary>Windows Plug and Play device identifier.</summary>
    public string? PNPDeviceID { get; init; }

    /// <summary>Port name used for the printer.</summary>
    public string? PortName { get; init; }

    /// <summary>Array of power management capabilities of the device.</summary>
    public ushort[]? PowerManagementCapabilities { get; init; }

    /// <summary>Whether the device supports power management.</summary>
    public bool? PowerManagementSupported { get; init; }

    /// <summary>Array of paper names the printer supports.</summary>
    public string[]? PrinterPaperNames { get; init; }

    /// <summary>Overall status of the printer (0 = Idle, 1 = Paused, 2 = Error, etc.).</summary>
    public ushort? PrinterStatus { get; init; }

    /// <summary>Default data type used by the print provider.</summary>
    public string? PrintJobDataType { get; init; }

    /// <summary>Name of the print processor.</summary>
    public string? PrintProcessor { get; init; }

    /// <summary>Priority for the print queue (1 = Lowest, 99 = Highest).</summary>
    public uint? Priority { get; init; }

    /// <summary>Whether the printer is published in Active Directory.</summary>
    public bool? Published { get; init; }

    /// <summary>Whether the printer accepts only queued print jobs.</summary>
    public bool? Queued { get; init; }

    /// <summary>Whether the printer sends data as raw bytes only.</summary>
    public bool? RawOnly { get; init; }

    /// <summary>Name of the separator page file.</summary>
    public string? SeparatorFile { get; init; }

    /// <summary>Name of the server where the printer is shared.</summary>
    public string? ServerName { get; init; }

    /// <summary>Whether the printer is shared.</summary>
    public bool? Shared { get; init; }

    /// <summary>Share name of the printer.</summary>
    public string? ShareName { get; init; }

    /// <summary>Earliest time the printer is available (minutes from midnight UTC).</summary>
    public string? StartTime { get; init; }

    /// <summary>Current status of the printer.</summary>
    public string? Status { get; init; }

    /// <summary>State of the logical device.</summary>
    public ushort? StatusInfo { get; init; }

    /// <summary>Scoping system's CreationClassName.</summary>
    public string? SystemCreationClassName { get; init; }

    /// <summary>Name of the scoping system.</summary>
    public string? SystemName { get; init; }

    /// <summary>Date and time the printer was last reset.</summary>
    public string? TimeOfLastReset { get; init; }

    /// <summary>Latest time the printer is available (minutes from midnight UTC).</summary>
    public string? UntilTime { get; init; }

    /// <summary>Vertical resolution of the printer in pixels per inch.</summary>
    public uint? VerticalResolution { get; init; }

    /// <summary>Whether the printer can work offline.</summary>
    public bool? WorkOffline { get; init; }
}
