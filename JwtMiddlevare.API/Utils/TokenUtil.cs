using JwtMiddlevare.API.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtMiddlevare.API.Utils
{
    public class TokenUtil : ITokenUtil
    {
        private readonly JwtSettings jwtSettings;
        public TokenUtil(IOptions<JwtSettings> options)
        {
            jwtSettings = options.Value;
        }
        public async Task<Tokenresponse> GenerateToken(UserModel user)
        {
            if (String.IsNullOrEmpty(jwtSettings.Key)) return null!;

            var key = Encoding.ASCII.GetBytes(jwtSettings.Key);
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub,user.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email,user.Email!),
                    new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString(CultureInfo.InvariantCulture)),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.Role,user.Role!),
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                Audience = jwtSettings.Audience,
                Issuer = jwtSettings.Issuer,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = await Task.Run(() => jwtTokenHandler.CreateToken(tokenDescriptor));
            var jwtToken = await Task.Run(() => jwtTokenHandler.WriteToken(token));

            return new Tokenresponse
            {
                AccesToken = jwtToken,
                Email = user.Email,
                Id = user.Id,
                ExpiresAt = DateTime.UtcNow.AddHours(1),
                Role = user.Role,
            };
        }
    }
}
