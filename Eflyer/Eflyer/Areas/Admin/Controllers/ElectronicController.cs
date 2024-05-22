using Eflyer.Business.Exceptions;
using Eflyer.Business.Services.Abstracts;
using Eflyer.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eflyer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ElectronicController : Controller
    {
        private readonly IElectronicService _electronicService;

        public ElectronicController(IElectronicService electronicService)
        {
            _electronicService = electronicService;
        }

        public IActionResult Index(int page = 1)
        {
            var electronics = _electronicService.GetAllElectronics(page);
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling(electronics.Count / 2d);

            if (electronics.Count > 0)
                if (page < 1 || page > (int)Math.Ceiling(electronics.Count / 2d)) return View("Error");


            return View(electronics);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Electronic electronic)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                _electronicService.AddElectronic(electronic);
            }
            catch (ImageFileRequiredException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch (FileContentTypeException ex)
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

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int id)
        {
            var existElectronic = _electronicService.GetElectronic(x => x.Id == id);
            if (existElectronic == null)
                return View("Error");

            return View(existElectronic);
        }

        [HttpPost]
        public IActionResult Update(Electronic electronic)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                _electronicService.UpdateElectronic(electronic);
            }
            catch (FileContentTypeException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch (FileSizeException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch (EntityNotFoundException ex)
            {
                return View("Error");
            }
            catch (EntityFileNotFoundException ex)
            {
                return View("Error");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var existElectronic = _electronicService.GetElectronic(x => x.Id == id);
            if (existElectronic == null)
                return View("Error");

            return View(existElectronic);
        }

        [HttpPost]
        public IActionResult DeletePost(int id)
        {
            var existElectronic = _electronicService.GetElectronic(x => x.Id == id);
            if (existElectronic == null)
                return View("Error");

            try
            {
                _electronicService.RemoveElectronic(id);
            }
            catch (EntityNotFoundException ex)
            {
                return View("Error");
            }
            catch (EntityFileNotFoundException ex)
            {
                return View("Error");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
