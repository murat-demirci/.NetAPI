using JwtMiddleware.API.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JwtMiddleware.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly RandomContext _context;

        public TokenController(RandomContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Login(string name, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync();
            if (user.Password == password)
            {
                if (user.Token.Length > 0)
                    return Redirect("/WeatherForecast");
            }
            return BadRequest("Yanlsi sifre");
        }
    }
}
