using System;
using System.Collections.Generic;

namespace MyProject.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public int? SessionCount { get; set; }

    public virtual ICollection<Result> Results { get; } = new List<Result>();
}
