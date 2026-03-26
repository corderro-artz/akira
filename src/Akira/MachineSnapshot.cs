namespace Vaporsoft.Akira;

/// <summary>
/// A serializable master snapshot that wraps all individual snapshots together
/// with machine identification, timestamps, and collection metadata.
/// </summary>
public sealed class MachineSnapshot
{
    // ── Metadata ──────────────────────────────────────────────────────

    /// <summary>Name of the machine the snapshot was collected from.</summary>
    public string? MachineName { get; init; }

    /// <summary>DNS host name of the machine.</summary>
    public string? DnsHostName { get; init; }

    /// <summary>Domain or workgroup of the machine.</summary>
    public string? Domain { get; init; }

    /// <summary>Operating system description (e.g. "Microsoft Windows 11 Pro").</summary>
    public string? OsDescription { get; init; }

    /// <summary>Operating system version string.</summary>
    public string? OsVersion { get; init; }

    /// <summary>Runtime framework description (e.g. ".NET 10.0.0").</summary>
    public string? RuntimeDescription { get; init; }

    /// <summary>UTC timestamp when the overall collection started.</summary>
    public DateTimeOffset CollectedAtUtc { get; init; }

    /// <summary>Total wall-clock duration of the snapshot collection in milliseconds.</summary>
    public double TotalDurationMs { get; init; }

    /// <summary>Version of the Akira library that produced this snapshot.</summary>
    public string? AkiraVersion { get; init; }

    // ── Snapshots ─────────────────────────────────────────────────────

    /// <summary>BIOS snapshot result. Maps to Win32_BIOS.</summary>
    public SnapshotResult<BIOSSnapshot>? BIOS { get; init; }

    /// <summary>Baseboard (motherboard) snapshot result. Maps to Win32_BaseBoard.</summary>
    public SnapshotResult<BaseBoardSnapshot>? BaseBoard { get; init; }

    /// <summary>Battery snapshot results. Maps to Win32_Battery.</summary>
    public SnapshotResult<BatterySnapshot[]>? Batteries { get; init; }

    /// <summary>Computer system snapshot result. Maps to Win32_ComputerSystem.</summary>
    public SnapshotResult<ComputerSystemSnapshot>? ComputerSystem { get; init; }

    /// <summary>Computer system product snapshot result. Maps to Win32_ComputerSystemProduct.</summary>
    public SnapshotResult<ComputerSystemProductSnapshot>? ComputerSystemProduct { get; init; }

    /// <summary>Desktop monitor snapshot results. Maps to Win32_DesktopMonitor.</summary>
    public SnapshotResult<DesktopMonitorSnapshot[]>? DesktopMonitors { get; init; }

    /// <summary>Disk drive snapshot results. Maps to Win32_DiskDrive.</summary>
    public SnapshotResult<DiskDriveSnapshot[]>? DiskDrives { get; init; }

    /// <summary>Disk partition snapshot results. Maps to Win32_DiskPartition.</summary>
    public SnapshotResult<DiskPartitionSnapshot[]>? DiskPartitions { get; init; }

    /// <summary>Environment variable snapshot results. Maps to Win32_Environment.</summary>
    public SnapshotResult<EnvironmentSnapshot[]>? EnvironmentVariables { get; init; }

    /// <summary>Fan snapshot results. Maps to Win32_Fan.</summary>
    public SnapshotResult<FanSnapshot[]>? Fans { get; init; }

    /// <summary>Logical disk snapshot results. Maps to Win32_LogicalDisk.</summary>
    public SnapshotResult<LogicalDiskSnapshot[]>? LogicalDisks { get; init; }

    /// <summary>Network adapter snapshot results. Maps to Win32_NetworkAdapter.</summary>
    public SnapshotResult<NetworkAdapterSnapshot[]>? NetworkAdapters { get; init; }

    /// <summary>Network adapter configuration snapshot results. Maps to Win32_NetworkAdapterConfiguration.</summary>
    public SnapshotResult<NetworkAdapterConfigurationSnapshot[]>? NetworkAdapterConfigurations { get; init; }

    /// <summary>Operating system snapshot result. Maps to Win32_OperatingSystem.</summary>
    public SnapshotResult<OperatingSystemSnapshot>? OperatingSystem { get; init; }

    /// <summary>Physical memory snapshot results. Maps to Win32_PhysicalMemory.</summary>
    public SnapshotResult<PhysicalMemorySnapshot[]>? PhysicalMemory { get; init; }

    /// <summary>Printer snapshot results. Maps to Win32_Printer.</summary>
    public SnapshotResult<PrinterSnapshot[]>? Printers { get; init; }

    /// <summary>Processor snapshot results. Maps to Win32_Processor.</summary>
    public SnapshotResult<ProcessorSnapshot[]>? Processors { get; init; }

    /// <summary>Process snapshot results. Maps to Win32_Process.</summary>
    public SnapshotResult<ProcessSnapshot[]>? Processes { get; init; }

    /// <summary>Service snapshot results. Maps to Win32_Service.</summary>
    public SnapshotResult<ServiceSnapshot[]>? Services { get; init; }

    /// <summary>Sound device snapshot results. Maps to Win32_SoundDevice.</summary>
    public SnapshotResult<SoundDeviceSnapshot[]>? SoundDevices { get; init; }

    /// <summary>Startup command snapshot results. Maps to Win32_StartupCommand.</summary>
    public SnapshotResult<StartupCommandSnapshot[]>? StartupCommands { get; init; }

    /// <summary>Thermal zone temperature snapshot results. Maps to MSAcpi_ThermalZoneTemperature.</summary>
    public SnapshotResult<ThermalZoneTemperatureSnapshot[]>? ThermalZones { get; init; }

    /// <summary>Time zone snapshot result. Maps to Win32_TimeZone.</summary>
    public SnapshotResult<TimeZoneSnapshot>? TimeZone { get; init; }

    /// <summary>User account snapshot results. Maps to Win32_UserAccount.</summary>
    public SnapshotResult<UserAccountSnapshot[]>? UserAccounts { get; init; }

    /// <summary>Video controller (GPU) snapshot results. Maps to Win32_VideoController.</summary>
    public SnapshotResult<VideoControllerSnapshot[]>? VideoControllers { get; init; }

    /// <summary>Volume snapshot results. Maps to Win32_Volume.</summary>
    public SnapshotResult<VolumeSnapshot[]>? Volumes { get; init; }
}
