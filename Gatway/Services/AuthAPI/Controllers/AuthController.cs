using AuthAPI.Utils;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Login(string userName, string password)
        {
            TokenUtils._config = _configuration;
            return Ok(userName == "murat" && password == "123456" ? TokenUtils.GenerateToken() : new UnauthorizedResult());
        }
    }
}
