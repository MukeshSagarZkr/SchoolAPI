using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SchoolAPI.Models;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public UserDetailsController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        // GET: api/UserDetails
        [HttpGet]
        public async Task<ActionResult<List<UserDetail>>> GetUsers()
        {
            try
            {
                var users = await _dbContext.UserDetails.ToListAsync();
                if (users == null || users.Count == 0)
                {
                    return NotFound("No users found.");
                }
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"An error occurred while retrieving users: {ex.Message}");
            }
        }

        [HttpPost("authenticate")]
        public async Task<ActionResult<string>> AuthenticateUser([FromBody] UserDetail userDetail)
        {
            try
            {
                // Check if the user exists and the password matches (assuming password is stored in hashed format)
                var user = await _dbContext.UserDetails
                    .Where(p => p.UserUsername == userDetail.UserUsername && p.IsActive == true)
                    .FirstOrDefaultAsync();

                //if (user == null || !VerifyPassword(userDetail.UserPassword, user.UserPassword))
                if (user == null)
                {
                    return Unauthorized("Invalid username or password.");
                }

                // Generate a JWT token for the user
                var token = GenerateJwtToken(user);

                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"An error occurred while authenticating the user: {ex.Message}");
            }
        }

        // Helper method to verify password
        //private bool VerifyPassword(string inputPassword, string storedPasswordHash)
        //{
        //    // Assuming the stored password is hashed. You need to use the same hashing method.
        //    // If you're using a hashing algorithm like SHA-256 or bcrypt, implement verification logic here.
        //    return inputPassword == storedPasswordHash; // Example, should be replaced with proper hash verification
        //}

        // Helper method to generate JWT token

        private string GenerateJwtToken(UserDetail user)
        {
            // Check if SecretKey is null or empty to avoid a potential null reference
            var secretKey = _configuration["Jwt:SecretKey"];
            if (string.IsNullOrEmpty(secretKey))
            {
                throw new InvalidOperationException("JWT secret key is missing in the configuration.");
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));  // This line will not throw now
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [HttpGet("by-name/{userName}")]
        public async Task<ActionResult<UserDetail>> GetUserDetailsByName(string userName)
        {
            try
            {
                // Find the user by name (assuming UserUsername is the property that stores the name)
                var user = await _dbContext.UserDetails
                    .Where(u => u.UserUsername == userName && u.IsActive == true)
                    .FirstOrDefaultAsync();

                if (user == null)
                {
                    return NotFound($"User with name {userName} not found.");
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"An error occurred while retrieving user details: {ex.Message}");
            }
        }


    }
}
