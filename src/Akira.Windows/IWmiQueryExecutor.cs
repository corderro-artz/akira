using System.Management;

namespace Vaporsoft.Akira.Windows;

/// <summary>
/// Executes WMI queries and returns raw <see cref="ManagementObject"/> results.
/// Extracted behind an interface to support unit-test mocking.
/// </summary>
public interface IWmiQueryExecutor
{
    /// <summary>
    /// Executes a WQL query against the specified WMI namespace and returns
    /// the resulting property sets as dictionaries.
    /// </summary>
    IReadOnlyList<IReadOnlyDictionary<string, object?>> Query(string wmiNamespace, string wqlQuery);
}
