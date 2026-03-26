using Akira;

namespace Akira.Windows;

/// <summary>
/// WMI provider for <see cref="ProcessSnapshot"/>. Queries Win32_Process.
/// </summary>
public sealed class ProcessSnapshotProvider : WmiCollectionSnapshotProvider<ProcessSnapshot>
{
    /// <inheritdoc />
    public ProcessSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_Process";

    /// <inheritdoc />
    protected override ProcessSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        ExecutablePath = WmiValueConverter.AsString(p.GetValueOrDefault("ExecutablePath")),
        ExecutionState = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ExecutionState")),
        Handle = WmiValueConverter.AsString(p.GetValueOrDefault("Handle")),
        HandleCount = WmiValueConverter.AsUInt32(p.GetValueOrDefault("HandleCount")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        KernelModeTime = WmiValueConverter.AsUInt64(p.GetValueOrDefault("KernelModeTime")),
        MaximumWorkingSetSize = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MaximumWorkingSetSize")),
        MinimumWorkingSetSize = WmiValueConverter.AsUInt32(p.GetValueOrDefault("MinimumWorkingSetSize")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        OSCreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("OSCreationClassName")),
        OSName = WmiValueConverter.AsString(p.GetValueOrDefault("OSName")),
        OtherOperationCount = WmiValueConverter.AsUInt64(p.GetValueOrDefault("OtherOperationCount")),
        OtherTransferCount = WmiValueConverter.AsUInt64(p.GetValueOrDefault("OtherTransferCount")),
        PageFaults = WmiValueConverter.AsUInt32(p.GetValueOrDefault("PageFaults")),
        PageFileUsage = WmiValueConverter.AsUInt32(p.GetValueOrDefault("PageFileUsage")),
        ParentProcessId = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ParentProcessId")),
        PeakPageFileUsage = WmiValueConverter.AsUInt32(p.GetValueOrDefault("PeakPageFileUsage")),
        PeakVirtualSize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("PeakVirtualSize")),
        PeakWorkingSetSize = WmiValueConverter.AsUInt32(p.GetValueOrDefault("PeakWorkingSetSize")),
        Priority = WmiValueConverter.AsUInt32(p.GetValueOrDefault("Priority")),
        PrivatePageCount = WmiValueConverter.AsUInt64(p.GetValueOrDefault("PrivatePageCount")),
        ProcessId = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ProcessId")),
        QuotaNonPagedPoolUsage = WmiValueConverter.AsUInt32(p.GetValueOrDefault("QuotaNonPagedPoolUsage")),
        QuotaPagedPoolUsage = WmiValueConverter.AsUInt32(p.GetValueOrDefault("QuotaPagedPoolUsage")),
        QuotaPeakNonPagedPoolUsage = WmiValueConverter.AsUInt32(p.GetValueOrDefault("QuotaPeakNonPagedPoolUsage")),
        QuotaPeakPagedPoolUsage = WmiValueConverter.AsUInt32(p.GetValueOrDefault("QuotaPeakPagedPoolUsage")),
        ReadOperationCount = WmiValueConverter.AsUInt64(p.GetValueOrDefault("ReadOperationCount")),
        ReadTransferCount = WmiValueConverter.AsUInt64(p.GetValueOrDefault("ReadTransferCount")),
        SessionId = WmiValueConverter.AsUInt32(p.GetValueOrDefault("SessionId")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        TerminationDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("TerminationDate")),
        ThreadCount = WmiValueConverter.AsUInt32(p.GetValueOrDefault("ThreadCount")),
        UserModeTime = WmiValueConverter.AsUInt64(p.GetValueOrDefault("UserModeTime")),
        VirtualSize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("VirtualSize")),
        WindowsVersion = WmiValueConverter.AsString(p.GetValueOrDefault("WindowsVersion")),
        WorkingSetSize = WmiValueConverter.AsUInt64(p.GetValueOrDefault("WorkingSetSize")),
        WriteOperationCount = WmiValueConverter.AsUInt64(p.GetValueOrDefault("WriteOperationCount")),
        WriteTransferCount = WmiValueConverter.AsUInt64(p.GetValueOrDefault("WriteTransferCount")),
    };
}
