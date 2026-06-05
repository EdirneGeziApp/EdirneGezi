using EdirneGeziAPI.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace EdirneGeziAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RecommendationsController : ControllerBase
    {
        private readonly GeziDbContext _context;

        public RecommendationsController(GeziDbContext context)
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

        [HttpGet("today")]
        public async Task<IActionResult> GetTodayRecommendation()
        {
            int userId = GetUserId();

            var favoritePlaceIds = await _context.Favorites
                .Where(f => f.UserId == userId)
                .Select(f => f.PlaceId)
                .ToListAsync();

            var favoriteCategoryIds = await _context.Favorites
                .Where(f => f.UserId == userId)
                .Include(f => f.Place)
                .Where(f => f.Place != null)
                .Select(f => f.Place!.CategoryId)
                .Distinct()
                .ToListAsync();

            if (favoriteCategoryIds.Any())
            {
                var recommendedPlace = await _context.Places
                    .Include(p => p.Category)
                    .Where(p =>
                        favoriteCategoryIds.Contains(p.CategoryId) &&
                        !favoritePlaceIds.Contains(p.Id))
                    .OrderBy(p => Guid.NewGuid())
                    .Select(p => new
                    {
                        p.Id,
                        p.Name,
                        p.Description,
                        p.ImageUrl,
                        p.CategoryId,
                        CategoryName = p.Category != null ? p.Category.Name : "Diğer"
                    })
                    .FirstOrDefaultAsync();

                if (recommendedPlace != null)
                    return Ok(recommendedPlace);
            }

            var fallbackPlace = await _context.Places
                .Include(p => p.Category)
                .Where(p => !favoritePlaceIds.Contains(p.Id))
                .OrderBy(p => Guid.NewGuid())
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Description,
                    p.ImageUrl,
                    p.CategoryId,
                    CategoryName = p.Category != null ? p.Category.Name : "Diğer"
                })
                .FirstOrDefaultAsync();

            return Ok(fallbackPlace);
        }
    }
}