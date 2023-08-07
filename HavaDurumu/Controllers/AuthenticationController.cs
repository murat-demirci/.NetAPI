using HavaDurumu.DbUsers;
using HavaDurumu.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HavaDurumu.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly JwtSettings _jwtSettings;
        public AuthenticationController(IOptions<JwtSettings> jwtSettings)
        {
            //jwt sectiondaki bilgiler alinir
            _jwtSettings = jwtSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login([FromBody] Users apiUsers)
        {
            var user = IsUserExist(apiUsers);
            if (user == null)
                return NotFound("User Not Found!");
            var token = CreateToken(user);
            return Ok(token);
        }

        private string CreateToken(Users user)
        {
            if (_jwtSettings.Key == null) throw new Exception("Key Degeri NULL Olamaz!!");

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var Claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Name,user.Name!),
                new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString(CultureInfo.InvariantCulture)),
                new Claim(ClaimTypes.Role,user.Role!)
            };

            var token = new JwtSecurityToken(
                _jwtSettings.Issuer,
                _jwtSettings.Audience,
                Claims,
                expires: DateTime.UtcNow.AddMinutes(10),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        private Users IsUserExist(Users apiUsers) => ApiUsers.Users
                .FirstOrDefault(u => u.Name?.ToLower() == apiUsers.Name?.ToLower()
                && u.Password == apiUsers.Password)!;

    }
}
