using System;

namespace Edutech.Api.Infrastructure.Data;

public class Content
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Url { get; set; }
    public string? Description { get; set; }
    // Foreign Key for Content Type
    public Guid ContentTypeId { get; set; }
    public ContentType? ContentType { get; set; }
    // Foreign Key for Module
    public Guid ModuleId { get; set; }
    public Module? Module { get; set; }
}
