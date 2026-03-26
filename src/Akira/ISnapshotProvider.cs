namespace Akira;

/// <summary>
/// Defines a provider that collects a typed system snapshot.
/// </summary>
/// <typeparam name="TSnapshot">The snapshot type returned by the provider.</typeparam>
public interface ISnapshotProvider<TSnapshot>
{
    /// <summary>
    /// Collects a snapshot and returns it wrapped in a <see cref="SnapshotResult{T}"/>
    /// containing the data, timing, and success/failure metadata.
    /// </summary>
    Task<SnapshotResult<TSnapshot>> GetSnapshotAsync(CancellationToken cancellationToken = default);
}
