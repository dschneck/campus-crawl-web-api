using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccess.Entities {
    [Table("Admin")]
    public class Admin {
        public string Id { get; set;}

        [ForeignKey("User")]
        public string UserId { get; set;}
        [JsonIgnore]
        public User User { get; set;}

        [ForeignKey("RSO")]
        public string RSOId { get; set;}
        [JsonIgnore]
        public RSO RSO { get; set;}
    }
}
