using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_post.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Message()
        {

        }
    }
}
