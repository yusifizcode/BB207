using ConsoleAppwRepositoryPattern.Models;

namespace ConsoleAppwRepositoryPattern.Services.Abstracts
{
    public interface IProductService
    {
        void DeleteProduct(int id);
        void AddProduct(Product product);
        void UpdateProduct(int id, Product product);
        Product GetProduct(Predicate<Product>? predicate = null);
        List<Product> GetAllProducts(Predicate<Product>? predicate = null);
    }
}
