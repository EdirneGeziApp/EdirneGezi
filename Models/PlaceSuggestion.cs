using System.ComponentModel.DataAnnotations;

namespace EdirneGeziAPI.Models
{
    public class PlaceSuggestion
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string? ImageUrl { get; set; }

        public string Status { get; set; } = "Pending";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}