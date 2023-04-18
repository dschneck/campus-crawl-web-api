using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    [Table("User")]
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UniversityId { get; set; }
    }
}
