namespace EdirneGeziAPI.DTO
{
    public class PlaceCreateDto
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; } // Bu satır eksik olduğu için kırmızı yanıyordu
        public int CategoryId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}