using la_mia_pizzeria_post.Models;
using Microsoft.AspNetCore.Mvc;


namespace la_mia_pizzeria_post.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessageController : Controller
    {
        [HttpPost]
        public IActionResult Send([FromBody] Message  message)
        {
            Context context = new Context();
            context.Messages.Add(message);
            context.SaveChanges();
            return Ok();
        }
    }
}
