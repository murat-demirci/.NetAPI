using Microsoft.AspNetCore.Mvc;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private List<string[]> Customers = new List<string[]>
        {
            new string[] {"1", "Murat", "Demirci","Admin",},
            new string[] { "5", "Kevin", "De", "Pleb", },
            new string[] { "4", "Cust", "Ran", "Pleb", },
            new string[] { "3", "Max", "Karl", "Mederator", },
            new string[] { "2", "John", "Doe", "User", }
        };

        [HttpGet]
        public object Get()
        {
            return Customers;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(Customers.FirstOrDefault(x => x[0].Equals(id.ToString())));
        }
    }
}
