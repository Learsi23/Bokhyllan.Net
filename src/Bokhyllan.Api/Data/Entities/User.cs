using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Bokhyllan.Api.Data.Entities;

public sealed class User   
{

    public Guid Id { get; set; }

    // The address as the user typed it, and an upper-case copy that we search and compare on.
    public string Email { get; set; } = "";
    public string NormalizedEmail { get; set; } = "";

    public string DisplayName { get; set; } = "";

    //Never the password itself: a salted, slow hash
    public string PasswordHash { get; set; } = "";

    public string Role { get; set; } = Roles.User;

    //A random value that changes when the password changes or the user logs out everywhere.
    //Access tokens carry a copy; if the copies differ the token is no longer valid.

    public string


    public long? TotpLastUsedStep { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public List<ShelfItem> ShelfItems { get; set; } = [];
    public List<Review> Reviews { get; set; } = [];
    public List<RefreshToken> RefreshTokens { get; set; } = [];
    public List<RecoveryCode> RecoveryCodes { get; set; } = [];

}
