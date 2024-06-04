using BB207WebApi.Business.DTOs.CategoryDTOs;
using BB207WebApi.Business.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace BB207WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(_categoryService.Get(x => x.Id == id && !x.IsDeleted));
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_categoryService.GetAll(x => !x.IsDeleted));
    }

    [HttpPost]
    public IActionResult Create(CategoryCreateDTO createDTO)
    {
        _categoryService.Add(createDTO);
        return NoContent();
    }

    [HttpPut]
    public IActionResult Update(CategoryUpdateDTO categoryUpdate)
    {
        _categoryService.Update(categoryUpdate);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _categoryService.SoftDelete(id);
        return NoContent();
    }

    [HttpDelete]
    [Route("hardDelete/{id}")]
    public IActionResult HardDelete(int id)
    {
        _categoryService.HardDelete(id);
        return NoContent();
    }
}
