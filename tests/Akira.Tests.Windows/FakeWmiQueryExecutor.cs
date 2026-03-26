using Vaporsoft.Akira.Windows;

namespace Vaporsoft.Akira.Tests.Windows;

/// <summary>
/// A fake <see cref="IWmiQueryExecutor"/> that returns pre-configured rows.
/// </summary>
internal sealed class FakeWmiQueryExecutor : IWmiQueryExecutor
{
    private readonly IReadOnlyList<IReadOnlyDictionary<string, object?>> _rows;
    private readonly Exception? _exception;

    public string? LastNamespace { get; private set; }
    public string? LastQuery { get; private set; }

    public FakeWmiQueryExecutor(IReadOnlyList<IReadOnlyDictionary<string, object?>> rows)
    {
        _rows = rows;
    }

    public FakeWmiQueryExecutor(Exception exception)
    {
        _rows = Array.Empty<IReadOnlyDictionary<string, object?>>();
        _exception = exception;
    }

    public IReadOnlyList<IReadOnlyDictionary<string, object?>> Query(string wmiNamespace, string wqlQuery)
    {
        LastNamespace = wmiNamespace;
        LastQuery = wqlQuery;

        if (_exception is not null)
            throw _exception;

        return _rows;
    }

    public static FakeWmiQueryExecutor Empty() =>
        new(Array.Empty<IReadOnlyDictionary<string, object?>>());

    public static FakeWmiQueryExecutor WithSingleRow(Dictionary<string, object?> row) =>
        new(new[] { row });

    public static FakeWmiQueryExecutor WithRows(params Dictionary<string, object?>[] rows) =>
        new(rows);
}
