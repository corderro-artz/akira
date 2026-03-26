namespace Vaporsoft.Akira;

/// <summary>
/// Snapshot of a user account. Maps to Win32_UserAccount.
/// </summary>
public sealed class UserAccountSnapshot
{
    /// <summary>Flags that describe the characteristics of the account (bitmap).</summary>
    public uint? AccountType { get; init; }

    /// <summary>Short description in DOMAIN\Name format.</summary>
    public string? Caption { get; init; }

    /// <summary>Description of the user account.</summary>
    public string? Description { get; init; }

    /// <summary>Whether the account is disabled.</summary>
    public bool? Disabled { get; init; }

    /// <summary>Name of the Windows domain the account belongs to.</summary>
    public string? Domain { get; init; }

    /// <summary>Full name of the local user.</summary>
    public string? FullName { get; init; }

    /// <summary>Date and time the account was installed.</summary>
    public DateTime? InstallDate { get; init; }

    /// <summary>Whether this is a local account (true) or a domain account (false).</summary>
    public bool? LocalAccount { get; init; }

    /// <summary>Whether the account is locked out.</summary>
    public bool? Lockout { get; init; }

    /// <summary>Name of the user account.</summary>
    public string? Name { get; init; }

    /// <summary>Whether the password can be changed.</summary>
    public bool? PasswordChangeable { get; init; }

    /// <summary>Whether the password expires.</summary>
    public bool? PasswordExpires { get; init; }

    /// <summary>Whether a password is required.</summary>
    public bool? PasswordRequired { get; init; }

    /// <summary>Security identifier (SID) for the account.</summary>
    public string? SID { get; init; }

    /// <summary>Type of SID (e.g. 1 = User, 2 = Group, 3 = Domain).</summary>
    public byte? SIDType { get; init; }

    /// <summary>Current status of the user account.</summary>
    public string? Status { get; init; }
}
