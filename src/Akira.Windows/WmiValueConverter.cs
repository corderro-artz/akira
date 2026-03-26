using System.Globalization;
using System.Management;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// Converts raw WMI property values to strongly-typed CLR values.
/// </summary>
public static class WmiValueConverter
{
    /// <summary>Returns the value as a <see cref="string"/>, or <c>null</c>.</summary>
    public static string? AsString(object? value) =>
        value is null ? null : Convert.ToString(value, CultureInfo.InvariantCulture);

    /// <summary>Returns the value as a nullable <see cref="bool"/>.</summary>
    public static bool? AsBool(object? value) =>
        value is null ? null : Convert.ToBoolean(value, CultureInfo.InvariantCulture);

    /// <summary>Returns the value as a nullable <see cref="byte"/>.</summary>
    public static byte? AsByte(object? value) =>
        value is null ? null : Convert.ToByte(value, CultureInfo.InvariantCulture);

    /// <summary>Returns the value as a nullable <see cref="short"/>.</summary>
    public static short? AsInt16(object? value) =>
        value is null ? null : Convert.ToInt16(value, CultureInfo.InvariantCulture);

    /// <summary>Returns the value as a nullable <see cref="ushort"/>.</summary>
    public static ushort? AsUInt16(object? value) =>
        value is null ? null : Convert.ToUInt16(value, CultureInfo.InvariantCulture);

    /// <summary>Returns the value as a nullable <see cref="int"/>.</summary>
    public static int? AsInt32(object? value) =>
        value is null ? null : Convert.ToInt32(value, CultureInfo.InvariantCulture);

    /// <summary>Returns the value as a nullable <see cref="uint"/>.</summary>
    public static uint? AsUInt32(object? value) =>
        value is null ? null : Convert.ToUInt32(value, CultureInfo.InvariantCulture);

    /// <summary>Returns the value as a nullable <see cref="long"/>.</summary>
    public static long? AsInt64(object? value) =>
        value is null ? null : Convert.ToInt64(value, CultureInfo.InvariantCulture);

    /// <summary>Returns the value as a nullable <see cref="ulong"/>.</summary>
    public static ulong? AsUInt64(object? value) =>
        value is null ? null : Convert.ToUInt64(value, CultureInfo.InvariantCulture);

    /// <summary>Returns the value as a nullable <see cref="float"/>.</summary>
    public static float? AsFloat(object? value) =>
        value is null ? null : Convert.ToSingle(value, CultureInfo.InvariantCulture);

    /// <summary>Returns the value as a nullable <see cref="double"/>.</summary>
    public static double? AsDouble(object? value) =>
        value is null ? null : Convert.ToDouble(value, CultureInfo.InvariantCulture);

    /// <summary>Returns the value as a nullable <see cref="DateTime"/> parsed from a WMI DMTF datetime string.</summary>
    public static DateTime? AsDateTime(object? value)
    {
        if (value is null) return null;
        var s = value.ToString();
        if (string.IsNullOrWhiteSpace(s)) return null;
        return ManagementDateTimeConverter.ToDateTime(s);
    }

    /// <summary>Returns the value as a <see cref="string"/> array, or <c>null</c>.</summary>
    public static string[]? AsStringArray(object? value) =>
        value as string[];

    /// <summary>Returns the value as a <see cref="ushort"/> array, or <c>null</c>.</summary>
    public static ushort[]? AsUInt16Array(object? value) =>
        value as ushort[];

    /// <summary>Returns the value as a <see cref="byte"/> array, or <c>null</c>.</summary>
    public static byte[]? AsByteArray(object? value) =>
        value as byte[];

    /// <summary>Returns the value as a <see cref="uint"/> array, or <c>null</c>.</summary>
    public static uint[]? AsUInt32Array(object? value) =>
        value as uint[];
}
