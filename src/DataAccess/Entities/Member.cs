using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccess.Entities {
    [Table("Member")]
    public class Member {
        [ForeignKey("User")]
        public string UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }

        [ForeignKey("RSO")]
        public string RSOId { get; set; }
        [JsonIgnore]
        public RSO RSO { get; set; }
    }
}
