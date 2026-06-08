using EdirneGeziAPI.Data;
using EdirneGeziAPI.Models;
using EdirneGeziAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using System.Security.Claims;

namespace EdirneGeziAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PlaceSuggestionsController : ControllerBase
    {
        private readonly GeziDbContext _context;
        private readonly IWebHostEnvironment _environment;
        private readonly ImageModerationService _imageModerationService;

        public PlaceSuggestionsController(
            GeziDbContext context,
            IWebHostEnvironment environment,
            ImageModerationService imageModerationService)
        {
            _context = context;
            _environment = environment;
            _imageModerationService = imageModerationService;
        }

        private int GetUserId()
        {
            var userIdClaim =
                User.FindFirst(ClaimTypes.NameIdentifier)?.Value ??
                User.FindFirst("UserId")?.Value ??
                User.FindFirst("userId")?.Value ??
                User.FindFirst("id")?.Value ??
                User.FindFirst("nameid")?.Value ??
                User.FindFirst("sub")?.Value;

            if (string.IsNullOrEmpty(userIdClaim))
                throw new UnauthorizedAccessException("Kullanıcı bilgisi bulunamadı.");

            return int.Parse(userIdClaim);
        }

        private bool IsAdmin()
        {
            var role =
                User.FindFirst(ClaimTypes.Role)?.Value ??
                User.FindFirst("role")?.Value ??
                User.FindFirst("Role")?.Value;

            return role == "Admin" || role == "admin";
        }

        [HttpGet("count")]
        public async Task<IActionResult> GetMyPlaceSuggestionCount()
        {
            int userId = GetUserId();

            var count = await _context.PlaceSuggestions
                .CountAsync(p => p.UserId == userId);

            return Ok(new { count });
        }

        [HttpPost]
        public async Task<IActionResult> CreateSuggestion(
            [FromForm] string name,
            [FromForm] string description,
            [FromForm] int categoryId,
            [FromForm] double latitude,
            [FromForm] double longitude,
            [FromForm] IFormFile? imageFile)
        {
            int userId = GetUserId();

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
                    "place-suggestions"
                );

                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                var fileName = $"{Guid.NewGuid()}{extension}";
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                imageUrl = $"/uploads/place-suggestions/{fileName}";
            }

            var suggestion = new PlaceSuggestion
            {
                Id = 0,
                UserId = userId,
                Name = name,
                Description = description,
                CategoryId = categoryId,
                Latitude = latitude,
                Longitude = longitude,
                ImageUrl = imageUrl,
                Status = "Pending",
                CreatedAt = DateTime.UtcNow
            };

            _context.PlaceSuggestions.Add(suggestion);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Mekan önerisi admin onayına gönderildi." });
        }

        [HttpGet]
        public async Task<IActionResult> GetSuggestions()
        {
            if (!IsAdmin())
                return Forbid();

            var suggestions = await _context.PlaceSuggestions
                .OrderByDescending(s => s.CreatedAt)
                .ToListAsync();

            return Ok(suggestions);
        }

        [HttpPut("{id}/edit")]
        public async Task<IActionResult> EditSuggestion(
            int id,
            [FromBody] PlaceSuggestion updatedSuggestion)
        {
            if (!IsAdmin())
                return Forbid();

            var suggestion = await _context.PlaceSuggestions.FindAsync(id);

            if (suggestion == null)
                return NotFound("Öneri bulunamadı.");

            if (suggestion.Status == "Approved")
                return BadRequest("Onaylanmış öneri düzenlenemez.");

            suggestion.Name = updatedSuggestion.Name;
            suggestion.Description = updatedSuggestion.Description;
            suggestion.CategoryId = updatedSuggestion.CategoryId;
            suggestion.ImageUrl = updatedSuggestion.ImageUrl;
            suggestion.Latitude = updatedSuggestion.Latitude;
            suggestion.Longitude = updatedSuggestion.Longitude;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Mekan önerisi güncellendi."
            });
        }

        [HttpPut("{id}/approve")]
        public async Task<IActionResult> ApproveSuggestion(int id)
        {
            if (!IsAdmin())
                return Forbid();

            var suggestion = await _context.PlaceSuggestions.FindAsync(id);

            if (suggestion == null)
                return NotFound("Öneri bulunamadı.");

            if (suggestion.Status == "Approved")
                return BadRequest("Bu öneri zaten onaylanmış.");

            var place = new Place
            {
                Name = suggestion.Name,
                Description = suggestion.Description,
                CategoryId = suggestion.CategoryId,
                ImageUrl = suggestion.ImageUrl,
                Location = new Point(suggestion.Longitude, suggestion.Latitude)
                {
                    SRID = 4326
                }
            };

            _context.Places.Add(place);

            suggestion.Status = "Approved";

            await _context.SaveChangesAsync();

            return Ok(new { message = "Öneri onaylandı ve mekan listesine eklendi." });
        }

        [HttpPut("{id}/reject")]
        public async Task<IActionResult> RejectSuggestion(int id)
        {
            if (!IsAdmin())
                return Forbid();

            var suggestion = await _context.PlaceSuggestions.FindAsync(id);

            if (suggestion == null)
                return NotFound("Öneri bulunamadı.");

            suggestion.Status = "Rejected";

            await _context.SaveChangesAsync();

            return Ok(new { message = "Öneri reddedildi." });
        }
    }
}