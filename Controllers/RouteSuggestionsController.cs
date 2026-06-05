using EdirneGeziAPI.Data;
using EdirneGeziAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace EdirneGeziAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RouteSuggestionsController : ControllerBase
    {
        private readonly GeziDbContext _context;

        public RouteSuggestionsController(GeziDbContext context)
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

        // ✅ YENİ: Kullanıcının rota öneri sayısı
        [HttpGet("count")]
        public async Task<IActionResult> GetMyRouteSuggestionCount()
        {
            int userId = GetUserId();

            var count = await _context.RouteSuggestions
                .CountAsync(r => r.UserId == userId);

            return Ok(new { count });
        }

        [HttpPost]
        public async Task<IActionResult> CreateSuggestion(
            [FromBody] RouteSuggestion suggestion)
        {
            int userId = GetUserId();

            suggestion.Id = 0;
            suggestion.UserId = userId;
            suggestion.Status = "Pending";
            suggestion.CreatedAt = DateTime.UtcNow;

            _context.RouteSuggestions.Add(suggestion);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Rota önerisi admin onayına gönderildi."
            });
        }

        [HttpGet]
        public async Task<IActionResult> GetSuggestions()
        {
            if (!IsAdmin())
                return Forbid();

            var suggestions = await _context.RouteSuggestions
                .OrderByDescending(s => s.CreatedAt)
                .ToListAsync();

            return Ok(suggestions);
        }

        [HttpGet("approved")]
        [AllowAnonymous]
        public async Task<IActionResult> GetApprovedRoutes()
        {
            var routes = await _context.RouteSuggestions
                .Where(r => r.Status == "Approved")
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync();

            return Ok(routes);
        }

        [HttpPut("{id}/approve")]
        public async Task<IActionResult> ApproveSuggestion(int id)
        {
            if (!IsAdmin())
                return Forbid();

            var suggestion = await _context.RouteSuggestions.FindAsync(id);

            if (suggestion == null)
                return NotFound("Rota önerisi bulunamadı.");

            suggestion.Status = "Approved";

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Rota önerisi onaylandı."
            });
        }

        [HttpPut("{id}/reject")]
        public async Task<IActionResult> RejectSuggestion(int id)
        {
            if (!IsAdmin())
                return Forbid();

            var suggestion = await _context.RouteSuggestions.FindAsync(id);

            if (suggestion == null)
                return NotFound("Rota önerisi bulunamadı.");

            suggestion.Status = "Rejected";

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Rota önerisi reddedildi."
            });
        }

        [HttpPut("{id}/edit")]
        public async Task<IActionResult> EditSuggestion(
            int id,
            [FromBody] RouteSuggestion updatedSuggestion)
        {
            if (!IsAdmin())
                return Forbid();

            var suggestion = await _context.RouteSuggestions.FindAsync(id);

            if (suggestion == null)
                return NotFound("Rota önerisi bulunamadı.");

            suggestion.Title = updatedSuggestion.Title;
            suggestion.Description = updatedSuggestion.Description;
            suggestion.Places = updatedSuggestion.Places;
            suggestion.Duration = updatedSuggestion.Duration;
            suggestion.Distance = updatedSuggestion.Distance;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Rota önerisi güncellendi."
            });
        }
    }
}