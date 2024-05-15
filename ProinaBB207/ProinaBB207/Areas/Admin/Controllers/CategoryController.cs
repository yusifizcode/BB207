using Microsoft.AspNetCore.Mvc;
using ProniaBB207.Business.Exceptions;
using ProniaBB207.Business.Services.Abstracts;
using ProniaBB207.Core.Models;

namespace ProinaBB207.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetAllCategories();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
                return View();



            try
            {
                _categoryService.AddCategory(category);
            }
            catch (DuplicateCategoryException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch (Exception)
            {
                throw;
            }
            return RedirectToAction("Index");
        }
    }
}
