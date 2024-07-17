using System;
using System.Collections.Generic;

namespace arth_backend;

public partial class GeneralCategory
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
