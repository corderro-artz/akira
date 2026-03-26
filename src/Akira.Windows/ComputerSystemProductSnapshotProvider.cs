using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="ComputerSystemProductSnapshot"/>. Queries Win32_ComputerSystemProduct.
/// </summary>
public sealed class ComputerSystemProductSnapshotProvider : WmiSnapshotProvider<ComputerSystemProductSnapshot>
{
    /// <inheritdoc />
    public ComputerSystemProductSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_ComputerSystemProduct";

    /// <inheritdoc />
    protected override ComputerSystemProductSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        IdentifyingNumber = WmiValueConverter.AsString(p.GetValueOrDefault("IdentifyingNumber")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        SKUNumber = WmiValueConverter.AsString(p.GetValueOrDefault("SKUNumber")),
        UUID = WmiValueConverter.AsString(p.GetValueOrDefault("UUID")),
        Vendor = WmiValueConverter.AsString(p.GetValueOrDefault("Vendor")),
        Version = WmiValueConverter.AsString(p.GetValueOrDefault("Version")),
    };
}
