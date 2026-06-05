using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using EdirneGeziAPI.Data;
using EdirneGeziAPI.Models;
using NetTopologySuite.Geometries;
using EdirneGeziAPI.DTO;
using EdirneGeziAPI.Services;

namespace EdirneGeziAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly GeziDbContext _context;
        private readonly IWebHostEnvironment _environment;
        private readonly ImageModerationService _imageModerationService;
        private readonly TextModerationService _textModerationService;

        public PlacesController(
            GeziDbContext context,
            IWebHostEnvironment environment,
            ImageModerationService imageModerationService,
            TextModerationService textModerationService)
        {
            _context = context;
            _environment = environment;
            _imageModerationService = imageModerationService;
            _textModerationService = textModerationService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetPlaces()
        {
            var places = await _context.Places
                .Include(p => p.Category)
                .OrderBy(p => p.Id)
                .ToListAsync();

            var result = places.Select(p => new
            {
                p.Id,
                p.Name,
                p.Description,
                p.ImageUrl,
                CategoryId = p.CategoryId,
                CategoryName = p.Category?.Name,
                Latitude = p.Location?.Y,
                Longitude = p.Location?.X
            });

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlace(int id)
        {
            var place = await _context.Places
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (place == null)
                return NotFound($"{id} numaralı mekan bulunamadı.");

            var result = new
            {
                place.Id,
                place.Name,
                place.Description,
                place.ImageUrl,
                place.CategoryId,
                CategoryName = place.Category?.Name,
                Latitude = place.Location?.Y,
                Longitude = place.Location?.X
            };

            return Ok(result);
        }

        [HttpGet("nearby")]
        public async Task<IActionResult> GetNearbyPlaces(
            [FromQuery] double lat,
            [FromQuery] double lng,
            [FromQuery] double radiusKm = 2)
        {
            var places = await _context.Places
                .Include(p => p.Category)
                .Where(p => p.Location != null)
                .ToListAsync();

            var nearbyPlaces = places
                .Select(p =>
                {
                    var distanceInMeters = CalculateDistanceInMeters(
                        lat,
                        lng,
                        p.Location!.Y,
                        p.Location!.X
                    );

                    return new NearbyPlaceDto
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Description = p.Description,
                        ImageUrl = p.ImageUrl,
                        CategoryId = p.CategoryId,
                        CategoryName = p.Category?.Name,
                        Latitude = p.Location.Y,
                        Longitude = p.Location.X,
                        DistanceInMeters = Math.Round(distanceInMeters)
                    };
                })
                .Where(p => p.DistanceInMeters <= radiusKm * 1000)
                .OrderBy(p => p.DistanceInMeters)
                .ToList();

            return Ok(nearbyPlaces);
        }

        private static double CalculateDistanceInMeters(
            double lat1,
            double lon1,
            double lat2,
            double lon2)
        {
            const double earthRadiusMeters = 6371000;

            double dLat = ToRadians(lat2 - lat1);
            double dLon = ToRadians(lon2 - lon1);

            double a =
                Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(ToRadians(lat1)) *
                Math.Cos(ToRadians(lat2)) *
                Math.Sin(dLon / 2) *
                Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return earthRadiusMeters * c;
        }

        private static double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> PostPlace([FromBody] PlaceCreateDto dto)
        {
            var place = new Place
            {
                Name = dto.Name,
                Description = dto.Description,
                ImageUrl = dto.ImageUrl,
                CategoryId = dto.CategoryId,
                Location = new Point(dto.Longitude, dto.Latitude) { SRID = 4326 }
            };

            _context.Places.Add(place);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                place.Id,
                place.Name,
                place.Description,
                place.ImageUrl,
                place.CategoryId,
                Latitude = place.Location?.Y,
                Longitude = place.Location?.X
            });
        }

        [HttpGet("{id}/reviews")]
        public async Task<IActionResult> GetReviews(int id)
        {
            var placeExists = await _context.Places.AnyAsync(p => p.Id == id);

            if (!placeExists)
                return NotFound("Mekan bulunamadı.");

            var reviews = await _context.Reviews
                .Where(r => r.PlaceId == id)
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync();

            return Ok(reviews);
        }

        [Authorize]
        [HttpPost("{id}/reviews")]
        public async Task<IActionResult> AddReview(
            int id,
            [FromForm] string userName,
            [FromForm] string comment,
            [FromForm] int rating,
            [FromForm] IFormFile? imageFile)
        {
            var placeExists = await _context.Places.AnyAsync(p => p.Id == id);

            if (!placeExists)
                return NotFound("Yorum yapılmak istenen mekan bulunamadı.");

            if (string.IsNullOrWhiteSpace(comment))
                return BadRequest("Yorum boş olamaz.");

            if (!_textModerationService.IsTextSafe(comment))
                return BadRequest("Yorumunuz uygunsuz kelime içerdiği için gönderilemedi.");

            if (rating < 1 || rating > 5)
                return BadRequest("Puan 1 ile 5 arasında olmalıdır.");

            string? imageUrl = null;

            if (imageFile != null && imageFile.Length > 0)
            {
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".webp" };
                var extension = Path.GetExtension(imageFile.FileName).ToLower();

                if (!allowedExtensions.Contains(extension))
                    return BadRequest("Sadece jpg, jpeg, png veya webp formatında fotoğraf yüklenebilir.");

                if (imageFile.Length > 5 * 1024 * 1024)
                    return BadRequest("Fotoğraf boyutu en fazla 5 MB olabilir.");

                bool isImageSafe = await _imageModerationService.IsImageSafeAsync(imageFile);

                if (!isImageSafe)
                    return BadRequest("Bu fotoğraf topluluk kurallarına uygun değil.");

                var uploadsFolder = Path.Combine(
                    _environment.WebRootPath ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"),
                    "uploads",
                    "reviews"
                );

                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                var fileName = $"{Guid.NewGuid()}{extension}";
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                imageUrl = $"/uploads/reviews/{fileName}";
            }

            var review = new Review
            {
                PlaceId = id,
                UserName = userName,
                Comment = comment,
                Rating = rating,
                ImageUrl = imageUrl,
                CreatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)
            };

            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            return Ok(review);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("allreviews")]
        public async Task<IActionResult> GetAllReviews()
        {
            var reviews = await _context.Reviews
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync();

            return Ok(reviews);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{placeId}/reviews/{reviewId}")]
        public async Task<IActionResult> DeleteReview(int placeId, int reviewId)
        {
            var review = await _context.Reviews
                .FirstOrDefaultAsync(r => r.Id == reviewId && r.PlaceId == placeId);

            if (review == null)
                return NotFound("Yorum bulunamadı.");

            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Yorum silindi." });
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlace(int id)
        {
            var place = await _context.Places.FindAsync(id);

            if (place == null)
                return NotFound("Mekan bulunamadı.");

            _context.Places.Remove(place);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Mekan silindi." });
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePlace(int id, [FromBody] PlaceCreateDto dto)
        {
            var place = await _context.Places.FindAsync(id);

            if (place == null)
                return NotFound("Mekan bulunamadı.");

            place.Name = dto.Name;
            place.Description = dto.Description;
            place.ImageUrl = dto.ImageUrl;
            place.CategoryId = dto.CategoryId;
            place.Location = new Point(dto.Longitude, dto.Latitude) { SRID = 4326 };

            await _context.SaveChangesAsync();

            return Ok(new { message = "Mekan güncellendi." });
        }
    }
}