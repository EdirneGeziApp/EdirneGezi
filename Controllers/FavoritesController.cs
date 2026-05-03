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
    public class FavoritesController : ControllerBase
    {
        private readonly GeziDbContext _context;

        public FavoritesController(GeziDbContext context)
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

        [HttpGet]
        public async Task<IActionResult> GetFavorites()
        {
            int userId = GetUserId();

            var favorites = await _context.Favorites
                .Where(f => f.UserId == userId)
                .Include(f => f.Place)
                .Select(f => new
                {
                    f.Place!.Id,
                    f.Place.Name,
                    f.Place.Description,
                    f.Place.ImageUrl,
                    f.Place.CategoryId
                })
                .ToListAsync();

            return Ok(favorites);
        }

        [HttpGet("ids")]
        public async Task<IActionResult> GetFavoriteIds()
        {
            int userId = GetUserId();

            var ids = await _context.Favorites
                .Where(f => f.UserId == userId)
                .Select(f => f.PlaceId)
                .ToListAsync();

            return Ok(ids);
        }

        [HttpPost("{placeId}")]
        public async Task<IActionResult> AddFavorite(int placeId)
        {
            int userId = GetUserId();

            bool placeExists = await _context.Places.AnyAsync(p => p.Id == placeId);
            if (!placeExists)
                return NotFound("Mekan bulunamadı.");

            bool alreadyExists = await _context.Favorites
                .AnyAsync(f => f.UserId == userId && f.PlaceId == placeId);

            if (alreadyExists)
                return Ok(new { message = "Mekan zaten favorilerde." });

            var favorite = new Favorite
            {
                UserId = userId,
                PlaceId = placeId
            };

            _context.Favorites.Add(favorite);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Favorilere eklendi." });
        }

        [HttpDelete("{placeId}")]
        public async Task<IActionResult> RemoveFavorite(int placeId)
        {
            int userId = GetUserId();

            var favorite = await _context.Favorites
                .FirstOrDefaultAsync(f => f.UserId == userId && f.PlaceId == placeId);

            if (favorite == null)
                return NotFound("Favori bulunamadı.");

            _context.Favorites.Remove(favorite);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Favorilerden çıkarıldı." });
        }
    }
}