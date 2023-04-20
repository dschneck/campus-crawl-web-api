using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities {
    [Table("PrivateEvent")]
    public class PrivateEvent {
        public string Id { get; set;}

        [ForeignKey("University")]
        public string UniversityId { get; set; }
        public University University { get; set; }

        [ForeignKey("Event")]
        public string EventId { get; set; }

        [JsonIgnore]
        public Event Event { get; set; }
    }
}
