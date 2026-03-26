using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="UserAccountSnapshot"/>. Queries Win32_UserAccount.
/// </summary>
public sealed class UserAccountSnapshotProvider : WmiCollectionSnapshotProvider<UserAccountSnapshot>
{
    /// <inheritdoc />
    public UserAccountSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_UserAccount";

    /// <inheritdoc />
    protected override UserAccountSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        AccountType = WmiValueConverter.AsUInt32(p.GetValueOrDefault("AccountType")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        Disabled = WmiValueConverter.AsBool(p.GetValueOrDefault("Disabled")),
        Domain = WmiValueConverter.AsString(p.GetValueOrDefault("Domain")),
        FullName = WmiValueConverter.AsString(p.GetValueOrDefault("FullName")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        LocalAccount = WmiValueConverter.AsBool(p.GetValueOrDefault("LocalAccount")),
        Lockout = WmiValueConverter.AsBool(p.GetValueOrDefault("Lockout")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        PasswordChangeable = WmiValueConverter.AsBool(p.GetValueOrDefault("PasswordChangeable")),
        PasswordExpires = WmiValueConverter.AsBool(p.GetValueOrDefault("PasswordExpires")),
        PasswordRequired = WmiValueConverter.AsBool(p.GetValueOrDefault("PasswordRequired")),
        SID = WmiValueConverter.AsString(p.GetValueOrDefault("SID")),
        SIDType = WmiValueConverter.AsByte(p.GetValueOrDefault("SIDType")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
    };
}
