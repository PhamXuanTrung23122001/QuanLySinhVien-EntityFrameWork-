using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace MyProject.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public DateTime? BirthDate { get; set; }

    public bool Gender { 
        get; set; 
    }
  
   
    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public int? ClassId { get; set; }

    public virtual Class? Class { get; set; }

    public virtual ICollection<Result> Results { get; } = new List<Result>();

    


}
