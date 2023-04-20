using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccess.Entities {
    [Table("PublicEvent")]
    public class PublicEvent {
        public string Id { get; set;}

        [ForeignKey("Event")]
        public string EventId { get; set; }

        [JsonIgnore]
        public Event Event { get; set; }
    }
}
