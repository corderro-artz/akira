using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="StartupCommandSnapshot"/>. Queries Win32_StartupCommand.
/// </summary>
public sealed class StartupCommandSnapshotProvider : WmiCollectionSnapshotProvider<StartupCommandSnapshot>
{
    /// <inheritdoc />
    public StartupCommandSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_StartupCommand";

    /// <inheritdoc />
    protected override StartupCommandSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        Command = WmiValueConverter.AsString(p.GetValueOrDefault("Command")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        Location = WmiValueConverter.AsString(p.GetValueOrDefault("Location")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        SettingID = WmiValueConverter.AsString(p.GetValueOrDefault("SettingID")),
        User = WmiValueConverter.AsString(p.GetValueOrDefault("User")),
        UserSID = WmiValueConverter.AsString(p.GetValueOrDefault("UserSID")),
    };
}
