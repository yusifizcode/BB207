using Business.Services.Abstracts;
using Core.Models;
using Core.RepositoryAbstracts;
using Data.DAL;
using Data.RepositoryConcretes;

namespace Business.Services.Concretes;

public class ProductService : IProductService
{
    AppDbContext _appDb = new AppDbContext();
    IProductRepository _productRepository = new ProductRepository();
    public void AddProduct(Product product)
    {
        _productRepository.Add(product);
        _productRepository.Commit();
    }

    public void DeleteProduct(int id)
    {
        var product = _productRepository.Get(x => x.Id == id);
        if (product == null) throw new NullReferenceException();

        _productRepository.Delete(product);
        _productRepository.Commit();
    }

    public List<Product> GetAllProducts(Func<Product, bool>? predicate)
    {
        return _productRepository.GetAll(predicate, "Category");
    }

    public Product GetProduct(Func<Product, bool>? predicate)
    {
        return _productRepository.Get(predicate);
    }

    public void UpdateProduct(int id, Product product)
    {
        var existProduct = _productRepository.Get(x => x.Id == id);
        if (existProduct == null) throw new NullReferenceException();

        existProduct.Name = product.Name == "" ? existProduct.Name : product.Name;
        existProduct.Price = product.Price;
        existProduct.CategoryId = product.CategoryId;

        _productRepository.Commit();
    }
}
