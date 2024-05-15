using Microsoft.AspNetCore.Mvc;
using ProniaBB207.Business.Services.Abstracts;

namespace ProinaBB207.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        public HomeController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IActionResult Index()
        {
            var sliders = _sliderService.GetAllSliders();
            return View(sliders);
        }


    }
}
