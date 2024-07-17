using System;
using System.Collections.Generic;

namespace arth_backend;

public partial class Category
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? GeneralCategoryId { get; set; }

    public virtual GeneralCategory? GeneralCategory { get; set; }

    public virtual ICollection<ToolTemplate> ToolTemplates { get; set; } = new List<ToolTemplate>();

    public virtual ICollection<Tool> Tools { get; set; } = new List<Tool>();
}
