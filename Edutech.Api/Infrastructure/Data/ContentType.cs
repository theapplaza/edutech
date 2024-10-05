using System;

namespace Edutech.Api.Infrastructure.Data;

public class ContentType
{
    public Guid Id { get; set; }
    public required string Name { get; set; } // "Video", "Text"
    public ICollection<Content>? Contents { get; set; }
}
