namespace Vaporsoft.Akira;

/// <summary>
/// Snapshot of a Windows service. Maps to Win32_Service.
/// </summary>
public sealed class ServiceSnapshot
{
    /// <summary>Whether the service can be paused.</summary>
    public bool? AcceptPause { get; init; }

    /// <summary>Whether the service can be stopped.</summary>
    public bool? AcceptStop { get; init; }

    /// <summary>Short description of the service.</summary>
    public string? Caption { get; init; }

    /// <summary>Value the service increments periodically during long operations.</summary>
    public uint? CheckPoint { get; init; }

    /// <summary>Name of the first concrete class in the inheritance chain.</summary>
    public string? CreationClassName { get; init; }

    /// <summary>Whether the service has a delayed automatic start.</summary>
    public bool? DelayedAutoStart { get; init; }

    /// <summary>Description of the service.</summary>
    public string? Description { get; init; }

    /// <summary>Whether the service can interact with the desktop.</summary>
    public bool? DesktopInteract { get; init; }

    /// <summary>Display name of the service.</summary>
    public string? DisplayName { get; init; }

    /// <summary>Severity of the error if the service fails to start ("Normal", "Severe", etc.).</summary>
    public string? ErrorControl { get; init; }

    /// <summary>Windows error code from the last service start attempt.</summary>
    public uint? ExitCode { get; init; }

    /// <summary>Date and time the object was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Unique identifier of the service.</summary>
    public string? Name { get; init; }

    /// <summary>Fully qualified path to the service binary file.</summary>
    public string? PathName { get; init; }

    /// <summary>Process identifier of the service.</summary>
    public uint? ProcessId { get; init; }

    /// <summary>Service-specific error code.</summary>
    public uint? ServiceSpecificExitCode { get; init; }

    /// <summary>Type of service ("Kernel Driver", "Own Process", "Share Process", etc.).</summary>
    public string? ServiceType { get; init; }

    /// <summary>Whether the service is started.</summary>
    public bool? Started { get; init; }

    /// <summary>Start mode of the Windows base service ("Auto", "Manual", "Disabled").</summary>
    public string? StartMode { get; init; }

    /// <summary>Account name the service runs under.</summary>
    public string? StartName { get; init; }

    /// <summary>Current state of the service ("Running", "Stopped", etc.).</summary>
    public string? State { get; init; }

    /// <summary>Current status of the object.</summary>
    public string? Status { get; init; }

    /// <summary>CreationClassName of the scoping computer system.</summary>
    public string? SystemCreationClassName { get; init; }

    /// <summary>Name of the scoping system.</summary>
    public string? SystemName { get; init; }

    /// <summary>Unique tag value for the service in its load order group.</summary>
    public uint? TagId { get; init; }

    /// <summary>Estimated time in milliseconds for a pending operation.</summary>
    public uint? WaitHint { get; init; }
}
