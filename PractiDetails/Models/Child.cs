using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PractiDetails.Models;

public partial class Child
{
    [Key]
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? ParentIdNumber { get; set; }
    
    
    public string? IdNumber { get; set; }
}
