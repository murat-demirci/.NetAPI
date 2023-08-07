using JwtMiddlevare.API.EfContext;
using JwtMiddlevare.API.Models;
using JwtMiddlevare.API.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JwtMiddlevare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly InMemoryContext _context = InMemoryContext.Singleton;
        private readonly ITokenUtil _tokenUtil;

        public AuthController(ITokenUtil tokenUtil)
        {
            _tokenUtil = tokenUtil;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserDataModel userDataModel)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email!.Equals(userDataModel.Email) && u.Password!.Equals(userDataModel.Password));
            if (user == null) return Problem("E posta veya Sifre hatali");

            return Ok(await _tokenUtil.GenerateToken(user));
        }
    }
}
