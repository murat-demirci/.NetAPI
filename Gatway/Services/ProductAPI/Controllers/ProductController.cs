using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly List<string[]> Products = new List<string[]>
        {
            new string[] { "1", "Mouse", "99,90" },
            new string[] { "2", "Keyboard", "289,90" },
            new string[] { "3", "Headset", "548,90" },
            new string[] { "4", "Adapter", "19,90" },
            new string[] { "5", "Hdmi Cable", "9,90" },
            new string[] { "6", "Battery", "5,90" },
            new string[] { "7", "Gamepad", "79,90" },
        };
        [HttpGet]
        public List<string[]> Get()
        => Products;

        [HttpGet("{id}")]
        public string[] Get(int id)
            => Products.FirstOrDefault(p => p[0].Equals(id.ToString()))!;
    }
}

