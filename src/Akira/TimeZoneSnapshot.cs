namespace Vaporsoft.Akira;

/// <summary>
/// Snapshot of the time zone configuration. Maps to Win32_TimeZone.
/// </summary>
public sealed class TimeZoneSnapshot
{
    /// <summary>Current bias for local time translation in minutes (UTC = local time + bias).</summary>
    public int? Bias { get; init; }

    /// <summary>Short description of the time zone.</summary>
    public string? Caption { get; init; }

    /// <summary>Bias value in minutes used during daylight saving time (UTC = local time + Bias + DaylightBias).</summary>
    public int? DaylightBias { get; init; }

    /// <summary>DaylightDayOfWeek occurrence in DaylightMonth when the transition to daylight saving time occurs.</summary>
    public uint? DaylightDay { get; init; }

    /// <summary>Day of the week when the transition to daylight saving time occurs (0 = Sunday).</summary>
    public byte? DaylightDayOfWeek { get; init; }

    /// <summary>Hour of the day when the transition to daylight time occurs.</summary>
    public uint? DaylightHour { get; init; }

    /// <summary>Millisecond of the DaylightSecond when the transition to daylight time occurs.</summary>
    public uint? DaylightMillisecond { get; init; }

    /// <summary>Minute of the DaylightHour when the transition to daylight time occurs.</summary>
    public uint? DaylightMinute { get; init; }

    /// <summary>Month when the transition to daylight saving time occurs (1 = January).</summary>
    public uint? DaylightMonth { get; init; }

    /// <summary>Name of the time zone during daylight saving time.</summary>
    public string? DaylightName { get; init; }

    /// <summary>Second of the DaylightMinute when the transition to daylight time occurs.</summary>
    public uint? DaylightSecond { get; init; }

    /// <summary>Year when daylight saving time is in effect (0 means every year).</summary>
    public uint? DaylightYear { get; init; }

    /// <summary>Description of the time zone.</summary>
    public string? Description { get; init; }

    /// <summary>Identifier of the time zone setting.</summary>
    public string? SettingID { get; init; }

    /// <summary>Bias value in minutes used during standard time.</summary>
    public uint? StandardBias { get; init; }

    /// <summary>StandardDayOfWeek occurrence in StandardMonth when the transition to standard time occurs.</summary>
    public uint? StandardDay { get; init; }

    /// <summary>Day of the week when the transition to standard time occurs (0 = Sunday).</summary>
    public byte? StandardDayOfWeek { get; init; }

    /// <summary>Hour of the day when the transition to standard time occurs.</summary>
    public uint? StandardHour { get; init; }

    /// <summary>Millisecond of the StandardSecond when the transition to standard time occurs.</summary>
    public uint? StandardMillisecond { get; init; }

    /// <summary>Minute of the StandardHour when the transition to standard time occurs.</summary>
    public uint? StandardMinute { get; init; }

    /// <summary>Month when the transition to standard time occurs (1 = January).</summary>
    public uint? StandardMonth { get; init; }

    /// <summary>Name of the time zone during standard time.</summary>
    public string? StandardName { get; init; }

    /// <summary>Second of the StandardMinute when the transition to standard time occurs.</summary>
    public uint? StandardSecond { get; init; }

    /// <summary>Year when standard time is in effect (0 means every year).</summary>
    public uint? StandardYear { get; init; }
}
