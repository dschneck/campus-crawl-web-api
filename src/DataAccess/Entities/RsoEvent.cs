using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities {
    [Table("RsoEvent")]
    public class RsoEvent {
        public string Id { get; set;}

        [ForeignKey("RSO")]
        public string RsoId { get; set; }
        [JsonIgnore]
        public RSO RSO { get; set; }

        [ForeignKey("Event")]
        public string EventId { get; set; }
        [JsonIgnore]
        public Event Event { get; set; }
    }
}
