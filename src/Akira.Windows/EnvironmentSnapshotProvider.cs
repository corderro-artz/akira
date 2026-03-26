using Akira;

namespace Akira.Windows;

/// <summary>
/// WMI provider for <see cref="EnvironmentSnapshot"/>. Queries Win32_Environment.
/// </summary>
public sealed class EnvironmentSnapshotProvider : WmiCollectionSnapshotProvider<EnvironmentSnapshot>
{
    /// <inheritdoc />
    public EnvironmentSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_Environment";

    /// <inheritdoc />
    protected override EnvironmentSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        SystemVariable = WmiValueConverter.AsBool(p.GetValueOrDefault("SystemVariable")),
        UserName = WmiValueConverter.AsString(p.GetValueOrDefault("UserName")),
        VariableValue = WmiValueConverter.AsString(p.GetValueOrDefault("VariableValue")),
    };
}
