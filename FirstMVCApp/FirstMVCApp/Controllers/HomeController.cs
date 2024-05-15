using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
