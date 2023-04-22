using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccess.Entities {
    [Table("Admin")]
    public class Admin {
        public string Id { get; set;}

        [ForeignKey("Member")]
        public string MemberId { get; set;}
        [JsonIgnore]
        public Member Member { get; set;}
    }
}
