using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EdirneGeziAPI.Data;
using EdirneGeziAPI.Models;
using NetTopologySuite.Geometries;
using EdirneGeziAPI.DTO;

namespace EdirneGeziAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly GeziDbContext _context;

        public PlacesController(GeziDbContext context)
        {
            _context = context;
        }

        // GET: api/Places
        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetPlaces()
        {
            // Verileri veritabanından çekerken ID'ye göre küçükten büyüğe sıralıyoruz
            var places = await _context.Places
                .Include(p => p.Category)
                .OrderBy(p => p.Id) // Sıralamayı yapan kritik satır burası
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

        // GET: api/Places/5
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
            var userLocation = new Point(lng, lat) { SRID = 4326 };
            double radiusInMeters = radiusKm * 1000;

            var nearbyPlaces = await _context.Places
                .Where(p => p.Location != null && p.Location.Distance(userLocation) * 111320 <= radiusInMeters)
                .OrderBy(p => p.Location.Distance(userLocation))
                .Select(p => new NearbyPlaceDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    ImageUrl = p.ImageUrl,
                    Latitude = p.Location.Y,
                    Longitude = p.Location.X,
                    DistanceInMeters = Math.Round(p.Location.Distance(userLocation) * 111320)
                })
                .ToListAsync();

            return Ok(nearbyPlaces);
        }

        // POST: api/Places
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
    }
}