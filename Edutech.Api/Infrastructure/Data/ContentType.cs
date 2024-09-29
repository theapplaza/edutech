using System;

namespace Edutech.Api.Infrastructure.Data;

public class ContentType
{
    public int ContentTypeId { get; set; }
    public string TypeName { get; set; } // "Video", "Text"

    public ICollection<Content> Contents { get; set; }
}
