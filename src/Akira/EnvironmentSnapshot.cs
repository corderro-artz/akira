namespace Akira;

/// <summary>
/// Snapshot of an environment variable. Maps to Win32_Environment.
/// </summary>
public sealed class EnvironmentSnapshot
{
    /// <summary>Short description of the environment variable.</summary>
    public string? Caption { get; init; }

    /// <summary>Description of the environment variable.</summary>
    public string? Description { get; init; }

    /// <summary>Date and time the object was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Character string that names the environment variable.</summary>
    public string? Name { get; init; }

    /// <summary>Current status of the object.</summary>
    public string? Status { get; init; }

    /// <summary>Whether the variable is a system variable (true) or user variable (false).</summary>
    public bool? SystemVariable { get; init; }

    /// <summary>Placeholder for the user or system that owns this variable.</summary>
    public string? UserName { get; init; }

    /// <summary>Value of the environment variable.</summary>
    public string? VariableValue { get; init; }
}
