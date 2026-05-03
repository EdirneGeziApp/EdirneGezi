using EdirneGeziAPI.Data;
using EdirneGeziAPI.Models;
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

        public PlaceSuggestionsController(GeziDbContext context)
        {
            _context = context;
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

        [HttpPost]
        public async Task<IActionResult> CreateSuggestion([FromBody] PlaceSuggestion suggestion)
        {
            int userId = GetUserId();

            suggestion.Id = 0;
            suggestion.UserId = userId;
            suggestion.Status = "Pending";
            suggestion.CreatedAt = DateTime.UtcNow;

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