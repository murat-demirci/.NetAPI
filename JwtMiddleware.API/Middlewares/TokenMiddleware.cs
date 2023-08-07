using JwtMiddleware.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtMiddleware.API.Middlewares
{
    public class TokenMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _config;

        public TokenMiddleware(RequestDelegate next, IConfiguration config)
        {
            _next = next;
            _config = config;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var path = context.Request.Path;
            if (path == "/api/Token")
            {
                var name = context.Request.Query["name"].ToString();
                var password = context.Request.Query["password"].ToString();
                var bearerToken = context.Request.Query["token"].ToString();
                if (name is not null && password is not null && name == "murat" && password == "123")
                {
                    var claims = new[]
                    {
                    new Claim(JwtRegisteredClaimNames.Sub,_config["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("UserName", name),
                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _config["Jwt:Issuer"],
                        _config["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(30),
                        signingCredentials: signIn);
                    bearerToken = new JwtSecurityTokenHandler().WriteToken(token).ToString();
                    var user = new MyUsers { id = 1, Name = name, Password = password, Token = bearerToken };
                    using (var _context = new RandomContext())
                    {
                        _context.Users.Update(user);
                        await _context.SaveChangesAsync();
                    }
                    context.Request.Headers.Authorization = "Bearer " + bearerToken.ToString();
                    var s = context.Request.Headers.Authorization;
                }
            }

            if (path == "/WeatherForecast")
            {
                using (var _context = new RandomContext())
                {
                    var token = _context.Users.FirstOrDefaultAsync().Result.Token.ToString();
                    context.Request.Headers.Authorization = "Bearer " + token;
                    var s = context.Request.Headers.Authorization;
                }
            }
            await _next.Invoke(context);
        }
    }
}
