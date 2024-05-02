using Core.Models;

namespace Business.Services.Abstracts;

public interface IProductService
{
    void DeleteProduct(int id);
    void AddProduct(Product product);
    void UpdateProduct(int id, Product product);

    Product GetProduct(Func<Product, bool>? predicate);
    List<Product> GetAllProducts(Func<Product, bool>? predicate);
}
