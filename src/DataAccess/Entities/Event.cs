using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccess.Entities {
    [Table("Event")]
    public class Event {
        public string Id { get; set;}

        [ForeignKey("RSO")]
        public string RsoId { get; set;}
        [JsonIgnore]
        public RSO RSO { get; set;}

        [ForeignKey("Location")]
        public string LocationId { get; set;}
        [JsonIgnore]
        public Location Location { get; set;}

        public string Name { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

    }
}
