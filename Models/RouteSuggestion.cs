using System.ComponentModel.DataAnnotations;

namespace EdirneGeziAPI.Models
{
    public class RouteSuggestion
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Places { get; set; } = string.Empty;

        public string Duration { get; set; } = string.Empty;

        public string Distance { get; set; } = string.Empty;

        public string Status { get; set; } = "Pending";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}