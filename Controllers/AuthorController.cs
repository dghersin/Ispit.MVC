using Ispit.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ispit.MVC.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            List<Author> authors = new List<Author>();
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                authors.Add(new Author
                {
                    ID = i,
                    Name = $"AuthorName_{i}",
                    Age = random.Next(20, 60),
                    Bio = $"Bio_{i}"
                });
            }



            return View("Index", authors);
        }
    }
}
