using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EdirneGeziAPI.Models
{
    public class RouteSuggestionStop
    {
        public int Id { get; set; }

        public int RouteSuggestionId { get; set; }

        [JsonIgnore]
        public RouteSuggestion? RouteSuggestion { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public int Order { get; set; }
    }
}