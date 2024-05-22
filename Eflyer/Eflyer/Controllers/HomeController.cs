
using Eflyer.Business.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Eflyer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IElectronicService _electronicService;
        public HomeController(IElectronicService electronicService)
        {
            _electronicService = electronicService;
        }

        public IActionResult Index()
        {
            var electronics = _electronicService.GetAllElectronics();
            return View(electronics);
        }
    }
}
