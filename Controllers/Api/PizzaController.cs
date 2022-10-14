using la_mia_pizzeria_post.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace la_mia_pizzeria_post.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        Context _context;
        public PizzaController()
        {
            _context = new Context();
        }
        public IActionResult Get()
        {
            List<Pizza> pizzaList = _context.Pizza.ToList();


            return Ok(pizzaList);
        }
    }
}
