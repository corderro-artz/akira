using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="ServiceSnapshot"/>. Queries Win32_Service.
/// </summary>
public sealed class ServiceSnapshotProvider : WmiCollectionSnapshotProvider<ServiceSnapshot>
{
    /// <inheritdoc />
    public ServiceSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_Service";

    /// <inheritdoc />
    protected override ServiceSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        AcceptPause = WmiValueConverter.AsBool(p.GetValueOrDefault("AcceptPause")),
        AcceptStop = WmiValueConverter.AsBool(p.GetValueOrDefault("AcceptStop")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        CheckPoint = WmiValueConverter.AsUInt32(p.GetValueOrDefault("CheckPoint")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        DelayedAutoStart = WmiValueConverter.AsBool(p.GetValueOrDefault("DelayedAutoStart")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        DesktopInteract = WmiValueConverter.AsBool(p.GetValueOrDefault("DesktopInteract")),
        DisplayName = WmiValueConverter.AsString(p.GetValueOrDefault("DisplayName")),
        ErrorControl = WmiValueConverter.AsString(p.GetValueOrDefault("ErrorControl")),
        ExitCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ExitCode")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        PathName = WmiValueConverter.AsString(p.GetValueOrDefault("PathName")),
        ProcessId = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ProcessId")),
        ServiceSpecificExitCode = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ServiceSpecificExitCode")),
        ServiceType = WmiValueConverter.AsString(p.GetValueOrDefault("ServiceType")),
        Started = WmiValueConverter.AsBool(p.GetValueOrDefault("Started")),
        StartMode = WmiValueConverter.AsString(p.GetValueOrDefault("StartMode")),
        StartName = WmiValueConverter.AsString(p.GetValueOrDefault("StartName")),
        State = WmiValueConverter.AsString(p.GetValueOrDefault("State")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        SystemCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemCreationClassName")),
        SystemName = WmiValueConverter.AsString(p.GetValueOrDefault("SystemName")),
        TagId = WmiValueConverter.AsUInt32(p.GetValueOrDefault("TagId")),
        WaitHint = WmiValueConverter.AsUInt32(p.GetValueOrDefault("WaitHint")),
    };
}
