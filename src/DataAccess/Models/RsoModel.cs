using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccess.Models {
    public class RsoModel {
        public string Id { get; set;}

        public string UniversityId { get; set;}

        public string Name { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }
    }
}
