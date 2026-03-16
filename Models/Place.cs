using NetTopologySuite.Geometries;

namespace EdirneGeziAPI.Models
{
    public class Place
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        
        // PostGIS ile harita koordinatını (Enlem/Boylam) tutacağımız nokta
        public Point? Location { get; set; }

        // Hangi kategoriye ait olduğu
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}