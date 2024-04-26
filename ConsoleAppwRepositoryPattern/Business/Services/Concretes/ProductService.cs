using ConsoleAppwRepositoryPattern.Models;
using ConsoleAppwRepositoryPattern.Repositories.Abstracts;
using ConsoleAppwRepositoryPattern.Repositories.Concretes;
using ConsoleAppwRepositoryPattern.Services.Abstracts;

namespace ConsoleAppwRepositoryPattern.Services.Concretes
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository = new ProductRepository();
        public void AddProduct(Product product)
        {
            _productRepository.Add(product);
        }

        public void DeleteProduct(int id)
        {
            Product product = _productRepository.Get(x => x.Id == id);
            if (product == null) throw new NullReferenceException("Product not found!");

            _productRepository.Delete(product);
        }

        public List<Product> GetAllProducts(Predicate<Product>? predicate = null)
        {
            return _productRepository.GetAll(predicate);
        }

        public Product GetProduct(Predicate<Product>? predicate = null)
        {
            return _productRepository.Get(predicate);
        }

        public void UpdateProduct(int id, Product product)
        {
            Product existProduct = _productRepository.Get(x => x.Id == id);
            if (existProduct == null) throw new NullReferenceException("Product not found!");

            existProduct.Name = product.Name;
            existProduct.Price = product.Price;
            existProduct.Description = product.Description;
            existProduct.DiscountPercent = product.DiscountPercent;
        }
    }
}
