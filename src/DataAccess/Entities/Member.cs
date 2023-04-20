using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities {
    [Table("Member")]
    public class Member {
        public string Id { get; set;}

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("RSO")]
        public string RSOId { get; set; }
        public RSO RSO { get; set; }
    }
}
