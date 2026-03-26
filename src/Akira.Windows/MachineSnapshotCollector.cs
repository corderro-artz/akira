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
    /// <see cref="MachineSnapshot"/>.
    /// </summary>
    public async Task<MachineSnapshot> CollectAsync(CancellationToken cancellationToken = default)
    {
        var version = typeof(MachineSnapshot).Assembly
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
            ?.InformationalVersion;

        return new MachineSnapshot
        {
            MachineName = Environment.MachineName,
            DnsHostName = System.Net.Dns.GetHostName(),
            Domain = Environment.UserDomainName,
            OsDescription = RuntimeInformation.OSDescription,
            OsVersion = Environment.OSVersion.VersionString,
            RuntimeDescription = RuntimeInformation.FrameworkDescription,
            CollectedAtUtc = DateTimeOffset.UtcNow,
            AkiraVersion = version,
            BaseBoard = await new BaseBoardSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            Batteries = await new BatterySnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            BIOS = await new BIOSSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            ComputerSystem = await new ComputerSystemSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            ComputerSystemProduct = await new ComputerSystemProductSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            DesktopMonitors = await new DesktopMonitorSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            DiskDrives = await new DiskDriveSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            DiskPartitions = await new DiskPartitionSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            EnvironmentVariables = await new EnvironmentSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            Fans = await new FanSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            LogicalDisks = await new LogicalDiskSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            NetworkAdapters = await new NetworkAdapterSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            NetworkAdapterConfigurations = await new NetworkAdapterConfigurationSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            OperatingSystem = await new OperatingSystemSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            PhysicalMemory = await new PhysicalMemorySnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            Printers = await new PrinterSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            Processors = await new ProcessorSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            Processes = await new ProcessSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            Services = await new ServiceSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            SoundDevices = await new SoundDeviceSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            StartupCommands = await new StartupCommandSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            ThermalZones = await new ThermalZoneTemperatureSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            TimeZone = await new TimeZoneSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            UserAccounts = await new UserAccountSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            VideoControllers = await new VideoControllerSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
            Volumes = await new VolumeSnapshotProvider(_executor).GetSnapshotAsync(cancellationToken),
        };
    }
}
