using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities {
    [Table("Event")]
    public class Event {
        public string Id { get; set;}

        [ForeignKey("Admin")]
        public string AdminId { get; set;}
        public Admin Admin { get; set;}

        [ForeignKey("Location")]
        public string LocationId { get; set;}
        public Location Location { get; set;}

        public string Name { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

    }
}
