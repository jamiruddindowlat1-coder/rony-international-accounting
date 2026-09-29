using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Dtos.Security;

namespace InternationalAccountingSystem.API.Controllers.Security
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IConfiguration _config;

        public AuthController(ApplicationDbContext db, IConfiguration config)
        {
            _db = db;
            _config = config;
        }

        [HttpPost("login")]
        public async Task<ActionResult<ApiResponse<LoginResponseDto>>> Login([FromBody] LoginRequestDto request)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == request.Email && !u.IsDeleted);

            Console.WriteLine($"[DEBUG] Email: {request.Email}");
            Console.WriteLine($"[DEBUG] User found: {user != null}");

            if (user == null || string.IsNullOrEmpty(user.PasswordHash))
                return Unauthorized(ApiResponse<LoginResponseDto>.Fail("Invalid email or password"));

            Console.WriteLine($"[DEBUG] IsActive: {user.IsActive}");
            Console.WriteLine($"[DEBUG] IsLocked: {user.IsLocked}");
            Console.WriteLine($"[DEBUG] IsDeleted: {user.IsDeleted}");
            Console.WriteLine($"[DEBUG] PasswordHash: {user.PasswordHash}");

            if (user.IsLocked)
                return Unauthorized(ApiResponse<LoginResponseDto>.Fail("Account is locked"));

            if (!user.IsActive)
                return Unauthorized(ApiResponse<LoginResponseDto>.Fail("Account is inactive"));

            bool valid;
            try
            {
                valid = BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash);
                Console.WriteLine($"[DEBUG] BCrypt.Verify result: {valid}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DEBUG] BCrypt.Verify exception: {ex.Message}");
                valid = false;
            }

            if (!valid)
            {
                user.FailedLoginAttempts += 1;
                await _db.SaveChangesAsync();
                return Unauthorized(ApiResponse<LoginResponseDto>.Fail("Invalid email or password"));
            }

            user.FailedLoginAttempts = 0;
            user.LastLoginAt = DateTime.UtcNow;
            await _db.SaveChangesAsync();

            var jwtSection = _config.GetSection("Jwt");
            var key = jwtSection["Key"];
            var issuer = jwtSection["Issuer"];
            var audience = jwtSection["Audience"];
            var minutes = double.TryParse(jwtSection["AccessTokenMinutes"], out var m) ? m : 60;

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username ?? user.Email),
                new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var creds = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(minutes),
                signingCredentials: creds
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            var response = new LoginResponseDto
            {
                Token = tokenString,
                UserId = user.Id,
                Username = user.Username,
                Email = user.Email,
                Role = "Admin"
            };

            return Ok(ApiResponse<LoginResponseDto>.Ok(response));
        }

        // Temporary - Remove after use
        [HttpGet("hash")]
        [AllowAnonymous]
        public IActionResult GetHash([FromQuery] string password)
        {
            var hash = BCrypt.Net.BCrypt.HashPassword(password);
            return Ok(hash);
        }

        // Temporary - Remove after use
        [HttpGet("verify")]
        [AllowAnonymous]
        public IActionResult VerifyHash([FromQuery] string password, [FromQuery] string hash)
        {
            try
            {
                var result = BCrypt.Net.BCrypt.Verify(password, hash);
                return Ok(new { password, hash, result });
            }
            catch (Exception ex)
            {
                return Ok(new { error = ex.Message });
            }
        }
    }
}
