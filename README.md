<p align="center">
  <h1 align="center">Akira</h1>
  <p align="center">
    A cross-platform .NET system state snapshot library.<br/>
    Strongly-typed, immutable, AOT-ready.
  </p>
</p>

<p align="center">
  <a href="#installation">Installation</a> &bull;
  <a href="#quick-start">Quick Start</a> &bull;
  <a href="#snapshot-classes">Snapshot Classes</a> &bull;
  <a href="#architecture">Architecture</a> &bull;
  <a href="#api-reference">API Reference</a> &bull;
  <a href="#contributing">Contributing</a> &bull;
  <a href="#license">License</a>
</p>

---

## What Is Akira?

Akira captures a complete, point-in-time snapshot of a machine's hardware and software state and returns it as a single, serializable .NET object. Every property is strongly typed, every DTO is immutable, and the entire pipeline is compatible with Native AOT via `System.Text.Json` source generation.

Use it for fleet inventory, diagnostics dashboards, change detection, compliance auditing, or anywhere you need a structured view of what a machine looks like *right now*.

### Highlights

| | |
|---|---|
| **26 snapshot types** | BIOS, CPU, GPU, disks, memory, network, services, processes, and more |
| **1,000+ properties** | Full parity with Win32/WMI class definitions |
| **Immutable DTOs** | Every property is `{ get; init; }` with full nullable annotations |
| **`MachineSnapshot`** | One envelope object that bundles everything with metadata and timing |
| **`SnapshotResult<T>`** | Typed result wrapper with `Ok` / `Fail` / `Unsupported` factory methods |
| **AOT-ready** | Source-generated `System.Text.Json` serialization — zero reflection |
| **Multi-platform** | Core DTOs are platform-agnostic; providers are shipped per-platform |

---

## Installation

```bash
# Core library (DTOs, interfaces, JSON serialization)
dotnet add package Vaporsoft.Akira

# Windows providers (WMI-based)
dotnet add package Vaporsoft.Akira.Windows
```

> **Vaporsoft.Akira.Linux** and **Vaporsoft.Akira.MacOS** provider packages are planned.

---

## Quick Start

```csharp
using Vaporsoft.Akira;
using Vaporsoft.Akira.Windows;

// Create a WMI executor (the default implementation talks to real WMI)
var wmi = new WmiQueryExecutor();

// Collect a single snapshot
var cpuProvider = new ProcessorSnapshotProvider(wmi);
SnapshotResult<ProcessorSnapshot[]> result = await cpuProvider.GetSnapshotAsync();

if (result.Success)
{
    foreach (var cpu in result.Data!)
        Console.WriteLine($"{cpu.Name} — {cpu.NumberOfCores} cores @ {cpu.MaxClockSpeed} MHz");
}
```

### Serialize to JSON (AOT-safe)

```csharp
using System.Text.Json;

string json = JsonSerializer.Serialize(result, AkiraJsonContext.Default.SnapshotResultProcessorSnapshotArray);
```

### Build a full `MachineSnapshot`

```csharp
var snapshot = new MachineSnapshot
{
    MachineName  = Environment.MachineName,
    CollectedAtUtc = DateTimeOffset.UtcNow,
    AkiraVersion = "0.1.0",
    Processors   = await new ProcessorSnapshotProvider(wmi).GetSnapshotAsync(),
    BIOS         = await new BIOSSnapshotProvider(wmi).GetSnapshotAsync(),
    DiskDrives   = await new DiskDriveSnapshotProvider(wmi).GetSnapshotAsync(),
    // ... add as many or as few providers as you need
};

string json = JsonSerializer.Serialize(snapshot, AkiraJsonContext.Default.MachineSnapshot);
```

---

## Snapshot Classes

The table below lists every snapshot DTO and the native data source used on each platform.

| Snapshot Class | Win32 / WMI Class | Windows | Linux | macOS |
|---|---|---|---|---|
| `BaseBoardSnapshot` | `Win32_BaseBoard` | WMI | `/sys/class/dmi/id/*`, `dmidecode` | `system_profiler SPHardwareDataType` |
| `BatterySnapshot` | `Win32_Battery` | WMI | `/sys/class/power_supply/*`, `upower` | `ioreg -rc AppleSmartBattery` |
| `BIOSSnapshot` | `Win32_BIOS` | WMI | `/sys/class/dmi/id/*`, `dmidecode` | `system_profiler SPHardwareDataType` |
| `ComputerSystemSnapshot` | `Win32_ComputerSystem` | WMI | `/sys/class/dmi/id/*`, `hostnamectl` | `system_profiler SPHardwareDataType` |
| `ComputerSystemProductSnapshot` | `Win32_ComputerSystemProduct` | WMI | `/sys/class/dmi/id/*`, `dmidecode` | `system_profiler SPHardwareDataType` |
| `DesktopMonitorSnapshot` | `Win32_DesktopMonitor` | WMI | `xrandr`, `/sys/class/drm/*/edid` | `system_profiler SPDisplaysDataType` |
| `DiskDriveSnapshot` | `Win32_DiskDrive` | WMI | `lsblk -J`, `/sys/block/*/device/` | `diskutil list -plist` |
| `DiskPartitionSnapshot` | `Win32_DiskPartition` | WMI | `lsblk -Jp`, `/proc/partitions` | `diskutil list -plist` |
| `EnvironmentSnapshot` | `Win32_Environment` | WMI | `/proc/self/environ`, `env` | `env`, `launchctl getenv` |
| `FanSnapshot` | `Win32_Fan` | WMI | `/sys/class/hwmon/*/fan*`, `sensors` | `iStats`, SMC via IOKit |
| `LogicalDiskSnapshot` | `Win32_LogicalDisk` | WMI | `df`, `/proc/mounts` | `df`, `mount` |
| `NetworkAdapterSnapshot` | `Win32_NetworkAdapter` | WMI | `ip link`, `/sys/class/net/*` | `networksetup -listallhardwareports` |
| `NetworkAdapterConfigurationSnapshot` | `Win32_NetworkAdapterConfiguration` | WMI | `ip addr`, `nmcli` | `ifconfig`, `scutil` |
| `OperatingSystemSnapshot` | `Win32_OperatingSystem` | WMI | `/etc/os-release`, `uname -a` | `sw_vers`, `uname -a` |
| `PhysicalMemorySnapshot` | `Win32_PhysicalMemory` | WMI | `dmidecode -t memory` | `system_profiler SPMemoryDataType` |
| `PrinterSnapshot` | `Win32_Printer` | WMI | `lpstat -a`, CUPS API | `lpstat -a`, CUPS API |
| `ProcessSnapshot` | `Win32_Process` | WMI | `/proc/[pid]/*` | `sysctl kern.proc`, `ps` |
| `ProcessorSnapshot` | `Win32_Processor` | WMI | `/proc/cpuinfo`, `lscpu` | `sysctl hw`, `system_profiler SPHardwareDataType` |
| `ServiceSnapshot` | `Win32_Service` | WMI | `systemctl list-units`, D-Bus | `launchctl list` |
| `SoundDeviceSnapshot` | `Win32_SoundDevice` | WMI | `aplay -l`, `/proc/asound/` | `system_profiler SPAudioDataType` |
| `StartupCommandSnapshot` | `Win32_StartupCommand` | WMI | `systemd-analyze`, `~/.config/autostart/` | `osascript`, `~/Library/LaunchAgents/` |
| `ThermalZoneTemperatureSnapshot` | `MSAcpi_ThermalZoneTemperature` | WMI (`root\WMI`) | `/sys/class/thermal/thermal_zone*/temp` | SMC via IOKit |
| `TimeZoneSnapshot` | `Win32_TimeZone` | WMI | `timedatectl`, `/etc/timezone` | `systemsetup -gettimezone` |
| `UserAccountSnapshot` | `Win32_UserAccount` | WMI | `/etc/passwd`, `getent passwd` | `dscl . -list /Users` |
| `VideoControllerSnapshot` | `Win32_VideoController` | WMI | `lspci`, `/sys/class/drm/` | `system_profiler SPDisplaysDataType` |
| `VolumeSnapshot` | `Win32_Volume` | WMI | `lsblk -f`, `blkid` | `diskutil info -all -plist` |

---

## Architecture

### Project Structure

```
akira/
├── src/
│   ├── Akira/                  Core DTOs, interfaces, JSON context
│   ├── Akira.Windows/          WMI-based providers (net10.0-windows)
│   ├── Akira.Linux/            procfs/sysfs providers (planned)
│   └── Akira.MacOS/            IOKit/sysctl providers (planned)
├── tests/
│   ├── Akira.Tests/            Core DTO & serialization tests
│   └── Akira.Tests.Windows/    Windows provider tests
└── akira.slnx
```

### Data Flow

```
  Application
      │
      ▼
  ISnapshotProvider<T>.GetSnapshotAsync()
      │
      ├──► Vaporsoft.Akira.Windows ──► WMI (System.Management)
      ├──► Vaporsoft.Akira.Linux   ──► /proc, /sys, CLI tools  (planned)
      └──► Vaporsoft.Akira.MacOS   ──► IOKit, sysctl, CLI tools (planned)
      │
      ▼
  SnapshotResult<T>  →  MachineSnapshot  →  AkiraJsonContext
      │
      ▼
  26 strongly-typed DTOs, 1,000+ properties, zero reflection
```

Each platform package ships providers that implement `ISnapshotProvider<T>` using native OS APIs. The core `Vaporsoft.Akira` package contains only the DTOs, the interface, `SnapshotResult<T>`, and the AOT-safe JSON serialization context — it has **zero dependencies**.

### Provider Pattern

Every provider follows the same shape:

```csharp
// Singleton (one instance per machine, e.g. BIOS)
public class BIOSSnapshotProvider : WmiSnapshotProvider<BIOSSnapshot> { ... }

// Collection (multiple instances, e.g. disks, adapters)
public class DiskDriveSnapshotProvider : WmiCollectionSnapshotProvider<DiskDriveSnapshot> { ... }
```

Both base classes accept an `IWmiQueryExecutor`, making every provider fully unit-testable without touching real WMI.

---

## API Reference

### `ISnapshotProvider<TSnapshot>`

```csharp
public interface ISnapshotProvider<TSnapshot>
{
    Task<SnapshotResult<TSnapshot>> GetSnapshotAsync(CancellationToken cancellationToken = default);
}
```

### `SnapshotResult<T>`

| Property | Type | Description |
|---|---|---|
| `Data` | `T?` | The snapshot data, or `null` on failure |
| `Success` | `bool` | Whether collection succeeded |
| `IsSupported` | `bool` | Whether this snapshot type is supported on the current platform |
| `Error` | `string?` | Error message on failure |
| `Warnings` | `string[]?` | Non-fatal warnings |
| `Source` | `string?` | Provider identifier (e.g. `"WMI:Win32_Processor"`) |
| `CollectedAtUtc` | `DateTimeOffset` | UTC timestamp of collection |
| `DurationMs` | `double` | Collection duration in milliseconds |
| `IsPartial` | `bool` | Whether only partial data was returned |

**Factory methods:**

```csharp
SnapshotResult<T>.Ok(data, source, durationMs)
SnapshotResult<T>.Fail(source, error, durationMs)
SnapshotResult<T>.Unsupported(source)
```

### `MachineSnapshot`

A sealed class that aggregates every `SnapshotResult<T>` into one serializable envelope with machine identification (`MachineName`, `DnsHostName`, `Domain`), OS info (`OsDescription`, `OsVersion`), and collection metadata (`CollectedAtUtc`, `TotalDurationMs`, `AkiraVersion`).

### `AkiraJsonContext`

Pre-configured `System.Text.Json` source-generated context with camelCase naming, indented output, and null-property omission. Includes serialization metadata for all 26 snapshot types and their `SnapshotResult<T>` wrappers.

```csharp
// Use the pre-generated context for AOT-safe serialization
JsonSerializer.Serialize(snapshot, AkiraJsonContext.Default.MachineSnapshot);
JsonSerializer.Deserialize(json, AkiraJsonContext.Default.MachineSnapshot);
```

---

## Windows Providers

All 26 Windows providers use WMI via `System.Management`. Most query `root\CIMV2`; thermal zones query `root\WMI`.

| Provider | WMI Class | Type |
|---|---|---|
| `BaseBoardSnapshotProvider` | `Win32_BaseBoard` | Singleton |
| `BIOSSnapshotProvider` | `Win32_BIOS` | Singleton |
| `ComputerSystemSnapshotProvider` | `Win32_ComputerSystem` | Singleton |
| `ComputerSystemProductSnapshotProvider` | `Win32_ComputerSystemProduct` | Singleton |
| `OperatingSystemSnapshotProvider` | `Win32_OperatingSystem` | Singleton |
| `TimeZoneSnapshotProvider` | `Win32_TimeZone` | Singleton |
| `BatterySnapshotProvider` | `Win32_Battery` | Collection |
| `DesktopMonitorSnapshotProvider` | `Win32_DesktopMonitor` | Collection |
| `DiskDriveSnapshotProvider` | `Win32_DiskDrive` | Collection |
| `DiskPartitionSnapshotProvider` | `Win32_DiskPartition` | Collection |
| `EnvironmentSnapshotProvider` | `Win32_Environment` | Collection |
| `FanSnapshotProvider` | `Win32_Fan` | Collection |
| `LogicalDiskSnapshotProvider` | `Win32_LogicalDisk` | Collection |
| `NetworkAdapterSnapshotProvider` | `Win32_NetworkAdapter` | Collection |
| `NetworkAdapterConfigurationSnapshotProvider` | `Win32_NetworkAdapterConfiguration` | Collection |
| `PhysicalMemorySnapshotProvider` | `Win32_PhysicalMemory` | Collection |
| `PrinterSnapshotProvider` | `Win32_Printer` | Collection |
| `ProcessorSnapshotProvider` | `Win32_Processor` | Collection |
| `ProcessSnapshotProvider` | `Win32_Process` | Collection |
| `ServiceSnapshotProvider` | `Win32_Service` | Collection |
| `SoundDeviceSnapshotProvider` | `Win32_SoundDevice` | Collection |
| `StartupCommandSnapshotProvider` | `Win32_StartupCommand` | Collection |
| `ThermalZoneTemperatureSnapshotProvider` | `MSAcpi_ThermalZoneTemperature` | Collection |
| `UserAccountSnapshotProvider` | `Win32_UserAccount` | Collection |
| `VideoControllerSnapshotProvider` | `Win32_VideoController` | Collection |
| `VolumeSnapshotProvider` | `Win32_Volume` | Collection |

---

## Requirements

- **.NET 10.0** or later
- **Windows** providers require `net10.0-windows` (WMI / `System.Management`)
- No additional runtime dependencies for the core `Vaporsoft.Akira` package

---

## Contributing

Contributions are welcome. If you'd like to add Linux or macOS providers, open an issue first to discuss the approach.

1. Fork the repository
2. Create a feature branch
3. Write tests for any new providers
4. Submit a pull request

---

## License

[MIT](LICENSE) — Copyright &copy; 2026 [Corderro Artz](https://github.com/corderro-artz) / [Vaporsoft](https://www.vaporsoft.dev)
