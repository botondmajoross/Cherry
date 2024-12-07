using System;
using System.Collections.Generic;

namespace zh3gyak.ProjectModels;

public partial class Task
{
    public int TaskId { get; set; }

    public int ProjectId { get; set; }

    public string AssignedTo { get; set; } = null!;

    public string TaskName { get; set; } = null!;

    public string? Description { get; set; }
}
