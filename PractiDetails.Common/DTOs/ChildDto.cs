using PractiDetails.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PractiDetails.Common.DTOs
{
    public class ChildDto
    {
        [Key]
           public int Id { get; set; }
        public string? FirstName { get; set; }

        public DateTime? BirthDate { get; set; }
        public string? ParentIdNumber { get; set; }
        
        public string? IdNumber { get; set; }
    }
}