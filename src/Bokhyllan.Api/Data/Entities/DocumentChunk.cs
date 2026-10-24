
using Pgvector;


namespace Bokhyllan.Api.Data.Entities;

public enum ChunkSource
{   
   Book,    
   Review,
   Help,
   ShelfNote,
}
// A piece of text plus its embedding (a list of numbers that describes what the text means).
// The assistant finds relevant chunks by comparing embeddings. That is the "R" in RAG.

public sealed class DocumentChunk
{
    public Guid Id { get; set; }
    public ChunkSource Source { get; set; }
    public string SourceId { get; set; } = "";
    public Guid? BookId { get; set; }
    // null = public text. A value = private text that only this user may search in.
    public Guid? OwnerUserId { get; set; }
    public string Content { get; set; } = "";
    public Vector Embedding { get; set; } = null!;
    public DateTimeOffset UpdatedAt { get; set; }
}
