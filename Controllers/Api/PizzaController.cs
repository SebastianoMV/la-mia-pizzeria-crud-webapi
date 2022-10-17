using la_mia_pizzeria_post.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Data.Entity;

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
        [HttpGet]
        public IActionResult Get(string? name)
        {
            IQueryable<Pizza> pizzas;
            if (name != null)
            {
                pizzas = _context.Pizza.Include("Category").Include("Ingredients").Where(pizza => pizza.Nome.ToLower().Contains(name.ToLower()));

            }
            else
            {
                pizzas = _context.Pizza.Include("Category").Include("Ingredients");
            }

            return Ok(pizzas.ToList<Pizza>());

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Pizza pizza = _context.Pizza.Where(piz => piz.Id == id).FirstOrDefault();
            return Ok(pizza);
        }
    }
}
