using System;
using System.Collections.Generic;

namespace arth_backend;

public partial class ToolTemplate
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? CategoryId { get; set; }

    public string? Discription { get; set; }

    public virtual Category? Category { get; set; }
}
