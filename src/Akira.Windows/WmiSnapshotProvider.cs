using System.Diagnostics;
using Akira;

namespace Akira.Windows;

/// <summary>
/// Base class for WMI providers that return a single snapshot instance
/// (e.g. Win32_OperatingSystem, Win32_ComputerSystem).
/// </summary>
/// <typeparam name="TSnapshot">The snapshot DTO type.</typeparam>
public abstract class WmiSnapshotProvider<TSnapshot> : ISnapshotProvider<TSnapshot>
    where TSnapshot : new()
{
    private readonly IWmiQueryExecutor _executor;

    /// <summary>Initializes a new instance with the specified WMI query executor.</summary>
    protected WmiSnapshotProvider(IWmiQueryExecutor executor)
    {
        _executor = executor;
    }

    /// <summary>The WMI namespace to query (default: <c>root\CIMV2</c>).</summary>
    protected virtual string WmiNamespace => @"root\CIMV2";

    /// <summary>The WMI class name to query (e.g. <c>Win32_Processor</c>).</summary>
    protected abstract string WmiClassName { get; }

    /// <summary>The source name used in <see cref="SnapshotResult{T}"/>.</summary>
    protected virtual string SourceName => $"WMI:{WmiClassName}";

    /// <summary>Maps a WMI property dictionary to a snapshot DTO instance.</summary>
    protected abstract TSnapshot Map(IReadOnlyDictionary<string, object?> properties);

    /// <inheritdoc />
    public Task<SnapshotResult<TSnapshot>> GetSnapshotAsync(CancellationToken cancellationToken = default)
    {
        var sw = Stopwatch.StartNew();
        try
        {
            var rows = _executor.Query(WmiNamespace, $"SELECT * FROM {WmiClassName}");
            if (rows.Count == 0)
            {
                return Task.FromResult(SnapshotResult<TSnapshot>.Fail(
                    SourceName, $"No instances returned from {WmiClassName}.", sw.Elapsed.TotalMilliseconds));
            }

            var snapshot = Map(rows[0]);
            return Task.FromResult(SnapshotResult<TSnapshot>.Ok(snapshot, SourceName, sw.Elapsed.TotalMilliseconds));
        }
        catch (Exception ex)
        {
            return Task.FromResult(SnapshotResult<TSnapshot>.Fail(
                SourceName, ex.Message, sw.Elapsed.TotalMilliseconds));
        }
    }
}
