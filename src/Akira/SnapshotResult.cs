namespace Vaporsoft.Akira;

/// <summary>
/// Wraps the result of a snapshot collection attempt with metadata, timing, and error information.
/// </summary>
/// <typeparam name="T">The snapshot data type.</typeparam>
public sealed class SnapshotResult<T>
{
    /// <summary>The collected snapshot data, or <c>default</c> if collection failed.</summary>
    public T? Data { get; init; }

    /// <summary>Whether the snapshot type is supported on the current platform.</summary>
    public bool IsSupported { get; init; } = true;

    /// <summary>Whether the collection completed successfully.</summary>
    public bool Success { get; init; }

    /// <summary>Error message if collection failed.</summary>
    public string? Error { get; init; }

    /// <summary>Non-fatal warnings encountered during collection.</summary>
    public string[]? Warnings { get; init; }

    /// <summary>Name identifying the provider that produced this result.</summary>
    public string? Source { get; init; }

    /// <summary>UTC timestamp when the snapshot was collected.</summary>
    public DateTimeOffset CollectedAtUtc { get; init; }

    /// <summary>Time taken to collect the snapshot, in milliseconds.</summary>
    public double DurationMs { get; init; }

    /// <summary>Whether only partial data was returned.</summary>
    public bool IsPartial { get; init; }

    /// <summary>Creates a successful result.</summary>
    public static SnapshotResult<T> Ok(T data, string source, double durationMs) => new()
    {
        Data = data,
        Success = true,
        Source = source,
        CollectedAtUtc = DateTimeOffset.UtcNow,
        DurationMs = durationMs,
    };

    /// <summary>Creates a failed result.</summary>
    public static SnapshotResult<T> Fail(string source, string error, double durationMs) => new()
    {
        Success = false,
        Source = source,
        Error = error,
        CollectedAtUtc = DateTimeOffset.UtcNow,
        DurationMs = durationMs,
    };

    /// <summary>Creates a result indicating the snapshot type is not supported on this platform.</summary>
    public static SnapshotResult<T> Unsupported(string source) => new()
    {
        IsSupported = false,
        Success = false,
        Source = source,
        Error = "Not supported on the current platform.",
        CollectedAtUtc = DateTimeOffset.UtcNow,
    };
}
