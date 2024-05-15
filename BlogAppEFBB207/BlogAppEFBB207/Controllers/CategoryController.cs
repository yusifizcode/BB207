using Business.Services.Abstracts;
using Business.Services.Concretes;
using Core.Models;

namespace BlogAppEFBB207.Controllers;

public class CategoryController
{
    ICategoryService _categoryService = new CategoryService();

    public void AddCategory()
    {
        Console.WriteLine("Enter category name: ");
        string name = Console.ReadLine();

        Category category = new Category
        {
            Name = name
        };
        _categoryService.AddCategory(category);
    }

    public void DeleteCategory()
    {
        Console.WriteLine("Enter category id: ");
        int id = int.Parse(Console.ReadLine());

        _categoryService.DeleteCategory(id);
    }

    public void UpdateCategory()
    {
        Console.WriteLine("Enter category id: ");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter category name: ");
        string name = Console.ReadLine();

        Category category = new Category
        {
            Name = name
        };
        _categoryService.UpdateCategory(id, category);
    }

    public void GetCategory()
    {
        Console.WriteLine("Enter category id: ");
        int id = int.Parse(Console.ReadLine());

        var cat = _categoryService.GetCategory(x => x.Id == id);
        Console.WriteLine($"{cat.Id} - {cat.Name}");
    }

    public void GetAllCategories()
    {
        foreach (var cat in _categoryService.GetAllCategories(null))
        {
            Console.WriteLine($"{cat.Id} - {cat.Name}");
        }
    }
}
