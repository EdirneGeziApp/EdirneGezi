namespace EdirneGeziAPI.DTO// Kendi projenin adına göre burayı ayarlayabilirsin
{
    public class NearbyPlaceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double DistanceInMeters { get; set; } 
    }
}