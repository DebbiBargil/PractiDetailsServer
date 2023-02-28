using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PractiDetails.Models;

public partial class Parent
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int Id { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? MaleOrFemale { get; set; }

    public string? Hmo { get; set; }
    [ForeignKey("ParentId")]
    public virtual ICollection<Child> Children { get; } = new List<Child>();
    public string? IdNumber { get; set; }
}
