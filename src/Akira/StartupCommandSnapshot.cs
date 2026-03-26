namespace Vaporsoft.Akira;

/// <summary>
/// Snapshot of a startup command. Maps to Win32_StartupCommand.
/// </summary>
public sealed class StartupCommandSnapshot
{
    /// <summary>Short description of the startup command.</summary>
    public string? Caption { get; init; }

    /// <summary>Command run by the startup command.</summary>
    public string? Command { get; init; }

    /// <summary>Description of the startup command.</summary>
    public string? Description { get; init; }

    /// <summary>Location of the startup command (e.g. registry key or startup folder).</summary>
    public string? Location { get; init; }

    /// <summary>Name of the startup command.</summary>
    public string? Name { get; init; }

    /// <summary>Identifier for this configuration setting.</summary>
    public string? SettingID { get; init; }

    /// <summary>User name for whom this startup command runs.</summary>
    public string? User { get; init; }

    /// <summary>SID of the user for whom this startup command runs.</summary>
    public string? UserSID { get; init; }
}
