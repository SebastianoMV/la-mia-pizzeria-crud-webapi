using la_mia_pizzeria_post.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace la_mia_pizzeria_post.Controllers
{
    public class HomeController : Controller
    {
        readonly Context _context = new();

        public IActionResult Index()
        {
            List<Pizza> pizzaList = _context.Pizza.Include("Category").Include("Ingredients").ToList();
            return View(pizzaList);
        }

        public IActionResult Details(int id)
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }
    }
}
