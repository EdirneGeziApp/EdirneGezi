using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EdirneGeziAPI.Data;
using EdirneGeziAPI.DTO; // DTO'yu kullanmak için bu satırı ekledik
using EdirneGeziAPI.Models;

namespace EdirneGeziAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly GeziDbContext _context;

        public CategoriesController(GeziDbContext context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            // Sonsuz döngüden kurtulmak için Entity'i DTO'ya çeviriyoruz
            var categories = await _context.Categories
                .Select(c => new CategoryDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    IconUrl = c.IconUrl
                })
                .ToListAsync();

            return Ok(categories);
        }

        // POST: api/Categories
        [HttpPost]
        public async Task<IActionResult> PostCategory(CategoryDto categoryDto)
        {
            // Dışarıdan gelen DTO'yu, veritabanına yazılacak gerçek modele çeviriyoruz
            var newCategory = new Category 
            {
                Name = categoryDto.Name,
                IconUrl = categoryDto.IconUrl
            };

            _context.Categories.Add(newCategory);
            await _context.SaveChangesAsync();

            // Yeni oluşan ID'yi DTO'ya ekleyip geri döndürüyoruz
            categoryDto.Id = newCategory.Id;
            return CreatedAtAction(nameof(GetCategories), new { id = categoryDto.Id }, categoryDto);
        }
    }
}