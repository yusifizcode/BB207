using Microsoft.AspNetCore.Mvc;
using ProniaBB207.Business.Exceptions;
using ProniaBB207.Business.Services.Abstracts;
using ProniaBB207.Core.Models;

namespace ProinaBB207.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IActionResult Index()
        {
            var sliders = _sliderService.GetAllSliders();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                _sliderService.AddSlider(slider);
            }
            catch (FileContentTypeException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch (FileNullReferenceException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch (FileSizeException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var existSlider = _sliderService.GetSlider(x => x.Id == id);
            if (existSlider == null) return NotFound();

            return View(existSlider);
        }

        [HttpPost]
        public IActionResult DeleteSlider(int id)
        {
            var existSlider = _sliderService.GetSlider(x => x.Id == id);
            if (existSlider == null) return NotFound();

            try
            {
                _sliderService.RemoveSlider(id);
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound();
            }
            catch (ProniaBB207.Business.Exceptions.FileNotFoundException ex)
            {
                return NotFound();
            }

            catch (Exception ex)
            {
                return BadRequest();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var existSlider = _sliderService.GetSlider(x => x.Id == id);
            if (existSlider == null) return NotFound();

            return View(existSlider);
        }

        [HttpPost]
        public IActionResult Update(Slider slider)
        {
            if (!ModelState.IsValid)
                return View();
            _sliderService.UpdateSlider(slider.Id, slider);
            return RedirectToAction("index");
        }
    }
}
