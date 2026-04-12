using System.Reflection;
using System.Runtime.InteropServices;
using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// Collects a complete <see cref="MachineSnapshot"/> using all available
/// Windows WMI snapshot providers in a single call.
/// </summary>
public sealed class MachineSnapshotCollector
{
    private readonly IWmiQueryExecutor _executor;

    /// <summary>Initializes a new collector with the specified WMI query executor.</summary>
    public MachineSnapshotCollector(IWmiQueryExecutor executor)
    {
        _executor = executor;
    }

    /// <summary>
    /// Collects every available snapshot and returns a fully populated
    /// <see cref="MachineSnapshot"/>. All 26 providers run concurrently on
    /// the thread pool, so total duration is bounded by the slowest single
    /// provider rather than the sum of all provider durations.
    /// </summary>
    public async Task<MachineSnapshot> CollectAsync(CancellationToken cancellationToken = default)
    {
        var version = typeof(MachineSnapshot).Assembly
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
            ?.InformationalVersion;

        // Capture synchronous metadata before launching parallel work.
        var machineName        = Environment.MachineName;
        var dnsHostName        = System.Net.Dns.GetHostName();
        var domain             = Environment.UserDomainName;
        var osDescription      = RuntimeInformation.OSDescription;
        var osVersion          = Environment.OSVersion.VersionString;
        var runtimeDescription = RuntimeInformation.FrameworkDescription;
        var collectedAtUtc     = DateTimeOffset.UtcNow;

        // Each provider's GetSnapshotAsync wraps a blocking WMI Query() call in
        // Task.FromResult — it is synchronous under the hood. Task.Run pushes each
        // blocking call onto a thread-pool thread so all 26 run concurrently.
        var baseBoardTask             = Task.Run(() => new BaseBoardSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var batteriesTask             = Task.Run(() => new BatterySnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var biosTask                  = Task.Run(() => new BIOSSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var computerSystemTask        = Task.Run(() => new ComputerSystemSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var computerSystemProductTask = Task.Run(() => new ComputerSystemProductSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var desktopMonitorsTask       = Task.Run(() => new DesktopMonitorSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var diskDrivesTask            = Task.Run(() => new DiskDriveSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var diskPartitionsTask        = Task.Run(() => new DiskPartitionSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var environmentTask           = Task.Run(() => new EnvironmentSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var fansTask                  = Task.Run(() => new FanSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var logicalDisksTask          = Task.Run(() => new LogicalDiskSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var networkAdaptersTask       = Task.Run(() => new NetworkAdapterSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var networkAdapterConfigsTask = Task.Run(() => new NetworkAdapterConfigurationSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var operatingSystemTask       = Task.Run(() => new OperatingSystemSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var physicalMemoryTask        = Task.Run(() => new PhysicalMemorySnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var printersTask              = Task.Run(() => new PrinterSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var processorsTask            = Task.Run(() => new ProcessorSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var processesTask             = Task.Run(() => new ProcessSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var servicesTask              = Task.Run(() => new ServiceSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var soundDevicesTask          = Task.Run(() => new SoundDeviceSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var startupCommandsTask       = Task.Run(() => new StartupCommandSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var thermalZonesTask          = Task.Run(() => new ThermalZoneTemperatureSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var timeZoneTask              = Task.Run(() => new TimeZoneSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var userAccountsTask          = Task.Run(() => new UserAccountSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var videoControllersTask      = Task.Run(() => new VideoControllerSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);
        var volumesTask               = Task.Run(() => new VolumeSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken), cancellationToken);

        await Task.WhenAll(
            baseBoardTask, batteriesTask, biosTask, computerSystemTask,
            computerSystemProductTask, desktopMonitorsTask, diskDrivesTask,
            diskPartitionsTask, environmentTask, fansTask, logicalDisksTask,
            networkAdaptersTask, networkAdapterConfigsTask, operatingSystemTask,
            physicalMemoryTask, printersTask, processorsTask, processesTask,
            servicesTask, soundDevicesTask, startupCommandsTask, thermalZonesTask,
            timeZoneTask, userAccountsTask, videoControllersTask, volumesTask);

        // .Result is safe here — Task.WhenAll guarantees all tasks have completed.
        return new MachineSnapshot
        {
            MachineName                  = machineName,
            DnsHostName                  = dnsHostName,
            Domain                       = domain,
            OsDescription                = osDescription,
            OsVersion                    = osVersion,
            RuntimeDescription           = runtimeDescription,
            CollectedAtUtc               = collectedAtUtc,
            AkiraVersion                 = version,
            BaseBoard                    = baseBoardTask.Result,
            Batteries                    = batteriesTask.Result,
            BIOS                         = biosTask.Result,
            ComputerSystem               = computerSystemTask.Result,
            ComputerSystemProduct        = computerSystemProductTask.Result,
            DesktopMonitors              = desktopMonitorsTask.Result,
            DiskDrives                   = diskDrivesTask.Result,
            DiskPartitions               = diskPartitionsTask.Result,
            EnvironmentVariables         = environmentTask.Result,
            Fans                         = fansTask.Result,
            LogicalDisks                 = logicalDisksTask.Result,
            NetworkAdapters              = networkAdaptersTask.Result,
            NetworkAdapterConfigurations = networkAdapterConfigsTask.Result,
            OperatingSystem              = operatingSystemTask.Result,
            PhysicalMemory               = physicalMemoryTask.Result,
            Printers                     = printersTask.Result,
            Processors                   = processorsTask.Result,
            Processes                    = processesTask.Result,
            Services                     = servicesTask.Result,
            SoundDevices                 = soundDevicesTask.Result,
            StartupCommands              = startupCommandsTask.Result,
            ThermalZones                 = thermalZonesTask.Result,
            TimeZone                     = timeZoneTask.Result,
            UserAccounts                 = userAccountsTask.Result,
            VideoControllers             = videoControllersTask.Result,
            Volumes                      = volumesTask.Result,
        };
    }
}
