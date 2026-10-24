namespace Bokhyllan.Api.Data.Entities;

public sealed class RefreshToken
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    // SHA-256 of the token. A database leak then gives the attacker nothing usable.
    public string TokenHash { get; set; } = "";

    // All tokens created from one login share a family. If an old token is reused,
    // the whole family is revoked: someone has stolen a token.

    public Guid FamilyId { get; set; }

    // When the user logged in. Rotation never extends a session past MaxSessionDays from here.
    public DateTimeOffset SessionStartedAt { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset ExpiresAt { get; set; }
    public DateTimeOffset? RevokedAt { get; set; }
    public string? RevokedReason { get; set; }
    public string? CreatedByIp { get; set; }

}
