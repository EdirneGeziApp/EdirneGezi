namespace EdirneGeziAPI.DTO
{
    public class NearbyPlaceDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double DistanceInMeters { get; set; }
    }
}