using ConsoleAppwRepositoryPattern.Models;

namespace ConsoleAppwRepositoryPattern.Repositories.Abstracts
{
    public interface IProductRepository
    {
        void Delete(Product product);
        void Add(Product product);
        Product Get(Predicate<Product>? predicate = null);
        List<Product> GetAll(Predicate<Product>? predicate = null);
    }
}
