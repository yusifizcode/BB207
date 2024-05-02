using Core.Models;
using Core.RepositoryAbstracts;

namespace Data.RepositoryConcretes;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
}
