using System;
using System.Collections.Generic;

namespace arth_backend;

public partial class ToolPhoto
{
    public string Id { get; set; } = null!;

    public string? ToolId { get; set; }

    public string? PhotoUrl { get; set; }

    public virtual Tool? Tool { get; set; }
}
