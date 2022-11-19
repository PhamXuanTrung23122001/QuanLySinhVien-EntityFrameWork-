using System;
using System.Collections.Generic;

namespace MyProject.Models;

public partial class Class
{
    public int ClassId { get; set; }

    public string? ClassCode { get; set; }

    public virtual ICollection<Student> Students { get; } = new List<Student>();
}
