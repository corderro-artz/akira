using Akira.Windows;

namespace Akira.Tests.Windows;

public class WmiValueConverterTests
{
    // ── AsString ──────────────────────────────────────────────────────

    [Fact]
    public void AsString_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsString(null));

    [Fact]
    public void AsString_value_returns_string() =>
        Assert.Equal("hello", WmiValueConverter.AsString("hello"));

    [Fact]
    public void AsString_int_returns_string() =>
        Assert.Equal("42", WmiValueConverter.AsString(42));

    // ── AsBool ────────────────────────────────────────────────────────

    [Fact]
    public void AsBool_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsBool(null));

    [Fact]
    public void AsBool_true_returns_true() =>
        Assert.True(WmiValueConverter.AsBool(true));

    [Fact]
    public void AsBool_false_returns_false() =>
        Assert.False(WmiValueConverter.AsBool(false));

    // ── AsByte ────────────────────────────────────────────────────────

    [Fact]
    public void AsByte_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsByte(null));

    [Fact]
    public void AsByte_value_returns_byte() =>
        Assert.Equal((byte)255, WmiValueConverter.AsByte((byte)255));

    // ── AsInt16 ───────────────────────────────────────────────────────

    [Fact]
    public void AsInt16_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsInt16(null));

    [Fact]
    public void AsInt16_value_returns_short() =>
        Assert.Equal((short)-100, WmiValueConverter.AsInt16((short)-100));

    // ── AsUInt16 ──────────────────────────────────────────────────────

    [Fact]
    public void AsUInt16_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsUInt16(null));

    [Fact]
    public void AsUInt16_value_returns_ushort() =>
        Assert.Equal((ushort)65535, WmiValueConverter.AsUInt16((ushort)65535));

    // ── AsInt32 ───────────────────────────────────────────────────────

    [Fact]
    public void AsInt32_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsInt32(null));

    [Fact]
    public void AsInt32_value_returns_int() =>
        Assert.Equal(-42, WmiValueConverter.AsInt32(-42));

    // ── AsUInt32 ──────────────────────────────────────────────────────

    [Fact]
    public void AsUInt32_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsUInt32(null));

    [Fact]
    public void AsUInt32_value_returns_uint() =>
        Assert.Equal(42U, WmiValueConverter.AsUInt32(42U));

    // ── AsInt64 ───────────────────────────────────────────────────────

    [Fact]
    public void AsInt64_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsInt64(null));

    [Fact]
    public void AsInt64_value_returns_long() =>
        Assert.Equal(-999L, WmiValueConverter.AsInt64(-999L));

    // ── AsUInt64 ──────────────────────────────────────────────────────

    [Fact]
    public void AsUInt64_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsUInt64(null));

    [Fact]
    public void AsUInt64_value_returns_ulong() =>
        Assert.Equal(999UL, WmiValueConverter.AsUInt64(999UL));

    // ── AsFloat ───────────────────────────────────────────────────────

    [Fact]
    public void AsFloat_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsFloat(null));

    [Fact]
    public void AsFloat_value_returns_float() =>
        Assert.Equal(3.14f, WmiValueConverter.AsFloat(3.14f));

    // ── AsDouble ──────────────────────────────────────────────────────

    [Fact]
    public void AsDouble_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsDouble(null));

    [Fact]
    public void AsDouble_value_returns_double() =>
        Assert.Equal(3.14, WmiValueConverter.AsDouble(3.14));

    // ── AsDateTime ────────────────────────────────────────────────────

    [Fact]
    public void AsDateTime_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsDateTime(null));

    [Fact]
    public void AsDateTime_empty_string_returns_null() =>
        Assert.Null(WmiValueConverter.AsDateTime(""));

    [Fact]
    public void AsDateTime_whitespace_returns_null() =>
        Assert.Null(WmiValueConverter.AsDateTime("   "));

    [Fact]
    public void AsDateTime_dmtf_string_returns_datetime()
    {
        // DMTF format: yyyyMMddHHmmss.ffffff+UUU
        var result = WmiValueConverter.AsDateTime("20240115120000.000000+000");
        Assert.NotNull(result);
        Assert.Equal(2024, result!.Value.Year);
        Assert.Equal(1, result.Value.Month);
        Assert.Equal(15, result.Value.Day);
    }

    // ── AsStringArray ─────────────────────────────────────────────────

    [Fact]
    public void AsStringArray_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsStringArray(null));

    [Fact]
    public void AsStringArray_value_returns_array()
    {
        var input = new[] { "a", "b" };
        Assert.Same(input, WmiValueConverter.AsStringArray(input));
    }

    [Fact]
    public void AsStringArray_wrong_type_returns_null() =>
        Assert.Null(WmiValueConverter.AsStringArray(42));

    // ── AsUInt16Array ─────────────────────────────────────────────────

    [Fact]
    public void AsUInt16Array_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsUInt16Array(null));

    [Fact]
    public void AsUInt16Array_value_returns_array()
    {
        var input = new ushort[] { 1, 2, 3 };
        Assert.Same(input, WmiValueConverter.AsUInt16Array(input));
    }

    // ── AsByteArray ───────────────────────────────────────────────────

    [Fact]
    public void AsByteArray_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsByteArray(null));

    [Fact]
    public void AsByteArray_value_returns_array()
    {
        var input = new byte[] { 0xFF, 0x00 };
        Assert.Same(input, WmiValueConverter.AsByteArray(input));
    }

    // ── AsUInt32Array ─────────────────────────────────────────────────

    [Fact]
    public void AsUInt32Array_null_returns_null() =>
        Assert.Null(WmiValueConverter.AsUInt32Array(null));

    [Fact]
    public void AsUInt32Array_value_returns_array()
    {
        var input = new uint[] { 10, 20 };
        Assert.Same(input, WmiValueConverter.AsUInt32Array(input));
    }
}
