using Vaporsoft.Akira;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// WMI provider for <see cref="BaseBoardSnapshot"/>. Queries Win32_BaseBoard.
/// </summary>
public sealed class BaseBoardSnapshotProvider : WmiSnapshotProvider<BaseBoardSnapshot>
{
    /// <inheritdoc />
    public BaseBoardSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_BaseBoard";

    /// <inheritdoc />
    protected override BaseBoardSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        ConfigOptions = WmiValueConverter.AsStringArray(p.GetValueOrDefault("ConfigOptions")),
        CreationClassName = WmiValueConverter.AsString(p.GetValueOrDefault("CreationClassName")),
        Depth = WmiValueConverter.AsFloat(p.GetValueOrDefault("Depth")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        Height = WmiValueConverter.AsFloat(p.GetValueOrDefault("Height")),
        HostingBoard = WmiValueConverter.AsBool(p.GetValueOrDefault("HostingBoard")),
        HotSwappable = WmiValueConverter.AsBool(p.GetValueOrDefault("HotSwappable")),
        InstallDate = WmiValueConverter.AsDateTime(p.GetValueOrDefault("InstallDate")),
        Manufacturer = WmiValueConverter.AsString(p.GetValueOrDefault("Manufacturer")),
        Model = WmiValueConverter.AsString(p.GetValueOrDefault("Model")),
        Name = WmiValueConverter.AsString(p.GetValueOrDefault("Name")),
        OtherIdentifyingInfo = WmiValueConverter.AsString(p.GetValueOrDefault("OtherIdentifyingInfo")),
        PartNumber = WmiValueConverter.AsString(p.GetValueOrDefault("PartNumber")),
        PoweredOn = WmiValueConverter.AsBool(p.GetValueOrDefault("PoweredOn")),
        Product = WmiValueConverter.AsString(p.GetValueOrDefault("Product")),
        Removable = WmiValueConverter.AsBool(p.GetValueOrDefault("Removable")),
        Replaceable = WmiValueConverter.AsBool(p.GetValueOrDefault("Replaceable")),
        RequirementsDescription = WmiValueConverter.AsString(p.GetValueOrDefault("RequirementsDescription")),
        RequiresDaughterBoard = WmiValueConverter.AsBool(p.GetValueOrDefault("RequiresDaughterBoard")),
        SerialNumber = WmiValueConverter.AsString(p.GetValueOrDefault("SerialNumber")),
        SKU = WmiValueConverter.AsString(p.GetValueOrDefault("SKU")),
        SlotLayout = WmiValueConverter.AsString(p.GetValueOrDefault("SlotLayout")),
        SpecialRequirements = WmiValueConverter.AsBool(p.GetValueOrDefault("SpecialRequirements")),
        Status = WmiValueConverter.AsString(p.GetValueOrDefault("Status")),
        Tag = WmiValueConverter.AsString(p.GetValueOrDefault("Tag")),
        Version = WmiValueConverter.AsString(p.GetValueOrDefault("Version")),
        Weight = WmiValueConverter.AsFloat(p.GetValueOrDefault("Weight")),
        Width = WmiValueConverter.AsFloat(p.GetValueOrDefault("Width")),
    };
}
