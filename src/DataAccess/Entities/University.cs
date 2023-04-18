using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities {
    [Table("University")]
    public class University {
        public string Id { get; set;}

        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public int NumberOfStudents { get; set; }
    }
}
