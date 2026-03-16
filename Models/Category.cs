namespace EdirneGeziAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? IconUrl { get; set; } 
        
        // Bir kategoride birden fazla mekanı olabilir
        public ICollection<Place>? Places { get; set; }
    }
}