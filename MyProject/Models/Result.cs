using System;
using System.Collections.Generic;

namespace MyProject.Models;

public partial class Result
{
    public int SubjectId { get; set; }

    public int StudentId { get; set; }

    public double? Mark { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
