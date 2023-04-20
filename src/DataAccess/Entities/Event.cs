using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities {
    [Table("Event")]
    public class Event {
        public string Id { get; set;}

        public string AdminId { get; set;}

        public string LocationId { get; set;}

        public string Name { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

    }
}
