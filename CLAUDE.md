# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

```bash
# Restore dependencies
dotnet restore

# Build (warnings treated as errors)
dotnet build --configuration Release -warnaserror

# Run all tests
dotnet test --configuration Release

# Run a single test project
dotnet test tests/Akira.Tests --configuration Release
dotnet test tests/Akira.Tests.Windows --configuration Release

# Run a specific test by name filter
dotnet test tests/Akira.Tests.Windows --configuration Release --filter "DisplayName~ProcessorSnapshot"

# Pack NuGet packages
dotnet pack --configuration Release --no-build --output artifacts
```

> `Akira.Tests.Windows` requires Windows (targets `net10.0-windows`). `Akira.Tests` is cross-platform (`net10.0`).

## Architecture

### Project layout

```
src/
  Akira/            Core library — DTOs, ISnapshotProvider<T>, SnapshotResult<T>, MachineSnapshot, AkiraJsonContext  (net10.0, zero dependencies)
  Akira.Windows/    WMI-based providers, MachineSnapshotCollector  (net10.0-windows, depends on System.Management)
  Akira.Linux/      Planned — procfs/sysfs providers
  Akira.MacOS/      Planned — IOKit/sysctl providers
tests/
  Akira.Tests/              Core DTO and JSON serialization tests  (net10.0)
  Akira.Tests.Windows/      Windows provider tests using FakeWmiQueryExecutor  (net10.0-windows)
```

### Core abstractions (src/Akira/)

- **`ISnapshotProvider<TSnapshot>`** — single async method `GetSnapshotAsync()` that all providers implement.
- **`SnapshotResult<T>`** — immutable result wrapper. Create via factory methods: `Ok(data, source, durationMs)`, `Fail(source, error, durationMs)`, `Unsupported(source)`.
- **`MachineSnapshot`** — sealed aggregate envelope holding one `SnapshotResult<T>` per snapshot type plus machine identification metadata.
- **`AkiraJsonContext`** — `System.Text.Json` source-generated context. Every new snapshot type and its `SnapshotResult<T>` wrappers **must** be registered here with `[JsonSerializable]` attributes to maintain AOT compatibility.

All DTOs use `{ get; init; }` properties with full nullable annotations and are intentionally immutable.

### Windows provider pattern (src/Akira.Windows/)

Two abstract base classes handle all boilerplate:

- **`WmiSnapshotProvider<TSnapshot>`** — for WMI classes that return a single object (e.g. `Win32_BIOS`). Override `WmiClassName` and `Map(properties)`.
- **`WmiCollectionSnapshotProvider<TSnapshot>`** — for WMI classes that return multiple objects (e.g. `Win32_Processor`). Same overrides, returns `TSnapshot[]`.

Both accept `IWmiQueryExecutor`, which enables unit testing without touching real WMI. Override `WmiNamespace` (default: `root\CIMV2`) for providers that query other namespaces (e.g. thermal zones use `root\WMI`).

**`WmiValueConverter`** — static helpers (`AsString`, `AsBool`, `AsUInt32`, `AsDateTime`, etc.) for converting raw `object?` WMI property values to typed CLR values. Use these in every `Map()` implementation.

**`MachineSnapshotCollector`** — convenience class that runs all 26 providers concurrently and populates `MachineSnapshot` metadata in a single `CollectAsync()` call.

### Testing Windows providers

Use `FakeWmiQueryExecutor` (in `tests/Akira.Tests.Windows/`) to inject pre-configured rows without a real WMI connection:

```csharp
var fake = FakeWmiQueryExecutor.WithSingleRow(new Dictionary<string, object?>
{
    ["Name"] = "Intel(R) Core(TM) i9",
    ["NumberOfCores"] = (uint)8,
});
var provider = new ProcessorSnapshotProvider(fake);
var result = await provider.GetSnapshotAsync();
```

### Adding a new snapshot type

1. Add the DTO to `src/Akira/` — immutable, `{ get; init; }`, fully nullable.
2. Register `[JsonSerializable(typeof(NewSnapshot))]` and `[JsonSerializable(typeof(SnapshotResult<NewSnapshot>))]` in `AkiraJsonContext.cs`.
3. Add the `SnapshotResult<NewSnapshot>?` property to `MachineSnapshot`.
4. Implement a provider in `src/Akira.Windows/` by extending `WmiSnapshotProvider<T>` or `WmiCollectionSnapshotProvider<T>`.
5. Wire the new provider into `MachineSnapshotCollector.CollectAsync()`.
6. Add provider tests using `FakeWmiQueryExecutor`.

## Deployment

NuGet packages are published automatically when a GitHub Release is created. The CI workflow builds, tests, packs, and pushes to both NuGet.org and GitHub Packages. Do not manually push packages.
