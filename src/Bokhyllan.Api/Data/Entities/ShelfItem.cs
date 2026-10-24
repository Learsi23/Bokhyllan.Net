namespace Bokhyllan.Api.Data.Entities;

public sealed class ShelfItem
{

    public Guid Id { get; set; }

    // The owner. Every query against shelf items MUST filter on this column.
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public Guid BookId { get; set; }
    public Book Book { get; set; } = null!;

    public ReadingStatus Status { get; set; }

    // Private: only the owner may ever see it.
    public string? PrivateNote { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public uint Version { get; set; }
}
