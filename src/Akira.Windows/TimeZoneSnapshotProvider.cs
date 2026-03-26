using Akira;

namespace Akira.Windows;

/// <summary>
/// WMI provider for <see cref="TimeZoneSnapshot"/>. Queries Win32_TimeZone.
/// </summary>
public sealed class TimeZoneSnapshotProvider : WmiSnapshotProvider<TimeZoneSnapshot>
{
    /// <inheritdoc />
    public TimeZoneSnapshotProvider(IWmiQueryExecutor executor) : base(executor) { }

    /// <inheritdoc />
    protected override string WmiClassName => "Win32_TimeZone";

    /// <inheritdoc />
    protected override TimeZoneSnapshot Map(IReadOnlyDictionary<string, object?> p) => new()
    {
        Bias = WmiValueConverter.AsInt32(p.GetValueOrDefault("Bias")),
        Caption = WmiValueConverter.AsString(p.GetValueOrDefault("Caption")),
        DaylightBias = WmiValueConverter.AsInt32(p.GetValueOrDefault("DaylightBias")),
        DaylightDay = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DaylightDay")),
        DaylightDayOfWeek = WmiValueConverter.AsByte(p.GetValueOrDefault("DaylightDayOfWeek")),
        DaylightHour = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DaylightHour")),
        DaylightMillisecond = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DaylightMillisecond")),
        DaylightMinute = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DaylightMinute")),
        DaylightMonth = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DaylightMonth")),
        DaylightName = WmiValueConverter.AsString(p.GetValueOrDefault("DaylightName")),
        DaylightSecond = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DaylightSecond")),
        DaylightYear = WmiValueConverter.AsUInt32(p.GetValueOrDefault("DaylightYear")),
        Description = WmiValueConverter.AsString(p.GetValueOrDefault("Description")),
        SettingID = WmiValueConverter.AsString(p.GetValueOrDefault("SettingID")),
        StandardBias = WmiValueConverter.AsUInt32(p.GetValueOrDefault("StandardBias")),
        StandardDay = WmiValueConverter.AsUInt32(p.GetValueOrDefault("StandardDay")),
        StandardDayOfWeek = WmiValueConverter.AsByte(p.GetValueOrDefault("StandardDayOfWeek")),
        StandardHour = WmiValueConverter.AsUInt32(p.GetValueOrDefault("StandardHour")),
        StandardMillisecond = WmiValueConverter.AsUInt32(p.GetValueOrDefault("StandardMillisecond")),
        StandardMinute = WmiValueConverter.AsUInt32(p.GetValueOrDefault("StandardMinute")),
        StandardMonth = WmiValueConverter.AsUInt32(p.GetValueOrDefault("StandardMonth")),
        StandardName = WmiValueConverter.AsString(p.GetValueOrDefault("StandardName")),
        StandardSecond = WmiValueConverter.AsUInt32(p.GetValueOrDefault("StandardSecond")),
        StandardYear = WmiValueConverter.AsUInt32(p.GetValueOrDefault("StandardYear")),
    };
}
