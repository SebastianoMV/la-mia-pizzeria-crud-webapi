using la_mia_pizzeria_post.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_post.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        public IActionResult Get()
        {
            Context _context = new();
            return Ok();
        }
    }
}
