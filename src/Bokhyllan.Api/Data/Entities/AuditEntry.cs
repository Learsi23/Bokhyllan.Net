namespace Bokhyllan.Api.Data.Entities
{
    // Who did what, when and from where. Rows are only ever inserted, never updated.
    public sealed class AuditEntry
    {
        public Guid Id { get; set; }
        public DateTimeOffset OccurredAt { get; set; }
        public Guid? UserId { get; set; }
        public string Action { get; set; } = "";
        public string? TargetId { get; set; }
        public string? IpAddress { get; set; }
        public string? Details { get; set; }
    }
}
