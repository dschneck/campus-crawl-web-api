using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccess.Entities {
    [Table("Member")]
    public class Member {
        public string Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }

        [ForeignKey("RSO")]
        public string RsoId { get; set; }
        [JsonIgnore]
        public RSO RSO { get; set; }
    }
}
