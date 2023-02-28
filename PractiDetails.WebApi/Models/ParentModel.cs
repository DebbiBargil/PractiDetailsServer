using PractiDetails.Models;

namespace PractiDetails.WebApi.Models
{
    public class ParentModel
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int Id { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? MaleOrFemale { get; set; }

        public string? Hmo { get; set; }

        public List<Child> Children { get; set; }
        public string? IdNumber { get; set; }
    }
}
