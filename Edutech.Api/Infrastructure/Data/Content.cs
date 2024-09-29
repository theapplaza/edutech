using System;

namespace Edutech.Api.Infrastructure.Data;

public class Content
{
    public int ContentId { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }

    // Foreign Key for Content Type
    public int ContentTypeId { get; set; }
    public ContentType ContentType { get; set; }

    // Foreign Key for Module
    public int ModuleId { get; set; }
    public Module Module { get; set; }
}
