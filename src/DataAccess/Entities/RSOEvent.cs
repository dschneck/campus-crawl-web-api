using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities {
    [Table("RSOEvent")]
    public class RSOEvent {
        public string Id { get; set;}

        [ForeignKey("RSO")]
        public string RSOId { get; set; }
        [JsonIgnore]
        public RSO RSO { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
    }
}
