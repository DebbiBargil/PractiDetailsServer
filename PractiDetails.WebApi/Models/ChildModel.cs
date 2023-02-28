using PractiDetails.Common.DTOs;

namespace PractiDetails.WebApi.Models
{
    public class ChildModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public DateTime? BirthDate { get; set; }
        public string? ParentIdNumber { get; set; }
     
        public string? IdNumber { get; set; }


    }
}
