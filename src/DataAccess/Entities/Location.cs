using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities {
    [Table("Location")]
    public class Location {
        public string Id { get; set;}

        public string Name { get; set; }

        public string Address { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }
    }
}
