using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EdirneGeziAPI.Data;
using EdirneGeziAPI.Models;

namespace EdirneGeziAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly GeziDbContext _context;

        public AuthController(GeziDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto dto)
        {
            bool emailExists = await _context.Users.AnyAsync(u => u.Email == dto.Email);
            if (emailExists)
                return BadRequest("Bu email adresi zaten kayıtlı.");

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);

            var user = new User
            {
                UserName = dto.UserName,
                Email = dto.Email,
                PasswordHash = passwordHash
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Kayıt başarılı!", userId = user.Id, userName = user.UserName, isAdmin = false });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            // Admin kontrolü
            if (dto.Email == "admin" && dto.Password == "admin")
            {
                return Ok(new { message = "Admin girişi başarılı!", userId = 0, userName = "Admin", isAdmin = true });
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == dto.Email);
            if (user == null)
                return Unauthorized("Email veya şifre hatalı.");

            bool passwordValid = BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash);
            if (!passwordValid)
                return Unauthorized("Email veya şifre hatalı.");

            return Ok(new { message = "Giriş başarılı!", userId = user.Id, userName = user.UserName, isAdmin = false });
        }

        // Admin: Tüm kullanıcıları getir
        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _context.Users
                .Select(u => new { u.Id, u.UserName, u.Email })
                .ToListAsync();
            return Ok(users);
        }

        // Admin: Kullanıcı sil
        [HttpDelete("users/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound("Kullanıcı bulunamadı.");
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Kullanıcı silindi." });
        }
    }

    public class RegisterDto
    {
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }

    public class LoginDto
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}