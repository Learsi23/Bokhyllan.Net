namespace Bokhyllan.Api.Data.Entities;

public sealed class Review
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Book Book { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    // 1-5 stars. Checked by validation AND by a CHECK constraint in the database.
    public int Rating { get; set; }

    // Written by users: untrusted text. It is HTML-encoded when shown and marked
    // as data (not instructions) when the AI assistant reads it.
    public string Text { get; set; } = "";
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public uint Version { get; set; }
    // Basic auditing: when the review was written and last edited (chapter 35).
    // xmin: two tabs editing the same review cannot overwrite each other.
    // Hidden by moderation (or automatically after several reports). Hidden reviews are not shown,
    // not counted in the average and not read by the assistant.
    public bool IsHidden { get; set; }
    public List<ReviewReport> Reports { get; set; } = [];
}
