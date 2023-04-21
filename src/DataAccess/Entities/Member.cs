using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccess.Entities {
    [Table("Member")]
    public class Member {
        [Key]
        [ForeignKey("User")]
        public string UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }

        [Key]
        [ForeignKey("RSO")]
        public string RSOId { get; set; }
        [JsonIgnore]
        public RSO RSO { get; set; }
    }
}
