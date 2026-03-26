using System.Management;

namespace Akira.Windows;

/// <summary>
/// Default <see cref="IWmiQueryExecutor"/> implementation that calls real WMI.
/// </summary>
public sealed class WmiQueryExecutor : IWmiQueryExecutor
{
    /// <inheritdoc />
    public IReadOnlyList<IReadOnlyDictionary<string, object?>> Query(string wmiNamespace, string wqlQuery)
    {
        using var searcher = new ManagementObjectSearcher(
            new ManagementScope(wmiNamespace),
            new ObjectQuery(wqlQuery));

        var results = new List<Dictionary<string, object?>>();

        foreach (ManagementBaseObject obj in searcher.Get())
        {
            var dict = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);
            foreach (var prop in obj.Properties)
            {
                dict[prop.Name] = prop.Value;
            }
            results.Add(dict);
            (obj as IDisposable)?.Dispose();
        }

        return results;
    }
}
