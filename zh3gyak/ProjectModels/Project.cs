using System;
using System.Collections.Generic;

namespace zh3gyak.ProjectModels;

public partial class Project
{
    public int ProjectId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string Status { get; set; } = null!;

    public string? Description { get; set; }
}
