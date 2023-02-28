using PractiDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiDetails.Common.DTOs
{
    public class ParentDto
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int Id { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? MaleOrFemale { get; set; }

        public string? Hmo { get; set; }

        public virtual ICollection<Child> Children { get; set; }
        public string? IdNumber { get; set; }
    }
}
