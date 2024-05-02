using Business.Services.Abstracts;
using Business.Services.Concretes;
using Core.Models;

namespace BlogAppEFBB207.Controllers;

public class ProductController
{
    IProductService _productService = new ProductService();
    ICategoryService _categoryService = new CategoryService();

    public void AddProduct()
    {
        Console.WriteLine("Enter product name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter product price: ");
        decimal price = decimal.Parse(Console.ReadLine());

        foreach (var item in _categoryService.GetAllCategories(null))
        {
            Console.WriteLine($"{item.Id} - {item.Name}");
        }
        Console.WriteLine("Enter category id: ");
        int categoryId = int.Parse(Console.ReadLine());

        Product product = new Product
        {
            Name = name,
            Price = price,
            CategoryId = categoryId
        };

        _productService.AddProduct(product);
    }

    public void DeleteProduct()
    {
        Console.WriteLine("Enter product id: ");
        int id = int.Parse(Console.ReadLine());

        _productService.DeleteProduct(id);
    }

    public void UpdateProduct()
    {
        Console.WriteLine("Enter product id: ");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter product name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter product price: ");
        decimal price = decimal.Parse(Console.ReadLine());

        foreach (var item in _categoryService.GetAllCategories(null))
        {
            Console.WriteLine($"{item.Id} - {item.Name}");
        }
        Console.WriteLine("Enter category id: ");
        int categoryId = int.Parse(Console.ReadLine());

        Product product = new Product
        {
            Name = name,
            Price = price,
            CategoryId = categoryId
        };

        _productService.UpdateProduct(id, product);
    }

    public void GetAllProducts()
    {
        foreach (var item in _productService.GetAllProducts(null))
        {
            Console.WriteLine($"{item.Id} - {item.Name} - {item.Price} - {item.Category.Name}");
        }
    }

    public void GetProduct()
    {
        Console.WriteLine("Enter product id: ");
        int id = int.Parse(Console.ReadLine());
        var item = _productService.GetProduct(x => x.Id == id);

        Console.WriteLine($"{item.Id} - {item.Name} - {item.Price} - {item.Category.Name}");
    }
}
