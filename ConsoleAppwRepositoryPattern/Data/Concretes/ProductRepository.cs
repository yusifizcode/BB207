using ConsoleAppwRepositoryPattern.DAL;
using ConsoleAppwRepositoryPattern.Models;
using ConsoleAppwRepositoryPattern.Repositories.Abstracts;

namespace ConsoleAppwRepositoryPattern.Repositories.Concretes
{
    public class ProductRepository : IProductRepository
    {
        public void Add(Product product)
        {
            AppDb.Products.Add(product);
        }

        public void Delete(Product product)
        {
            AppDb.Products.Remove(product);
        }

        public List<Product> GetAll(Predicate<Product>? predicate = null)
        {
            return predicate == null ?
                   AppDb.Products :
                   AppDb.Products.FindAll(predicate);
        }

        public Product Get(Predicate<Product>? predicate = null)
        {
            return predicate == null ?
                   AppDb.Products.Find(x => true) :
                   AppDb.Products.Find(predicate);
        }
    }
}
