namespace EdirneGeziAPI.DTO
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? IconUrl { get; set; } // Flutter tarafında butonlara ikon koymak isterse diye bunu da gönderiyoruz
    }
}