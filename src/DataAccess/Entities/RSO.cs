using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities {
    [Table("RSO")]
    public class RSO {
        public string Id { get; set;}

        [ForeignKey("University")]
        public string UniversityId { get; set;}
        public University University { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }
    }
}
