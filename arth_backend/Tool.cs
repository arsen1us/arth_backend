using System;
using System.Collections.Generic;

namespace arth_backend;

public partial class Tool
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? CategoryId { get; set; }

    public string? Discription { get; set; }

    public int? PricePerDay { get; set; }

    public int? PricePerWeek { get; set; }

    public int? PricePerMonth { get; set; }

    public bool? State { get; set; }

    public string? Address { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<ToolPhoto> ToolPhotos { get; set; } = new List<ToolPhoto>();
}
