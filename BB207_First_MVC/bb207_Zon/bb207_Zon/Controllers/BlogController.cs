using Microsoft.AspNetCore.Mvc;

namespace bb207_Zon.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
