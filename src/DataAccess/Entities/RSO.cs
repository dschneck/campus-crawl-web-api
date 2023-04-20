using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccess.Entities {
    [Table("RSO")]
    public class RSO {
        public string Id { get; set;}

        [ForeignKey("University")]
        public string UniversityId { get; set;}
        [JsonIgnore]
        public University University { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }
    }
}
