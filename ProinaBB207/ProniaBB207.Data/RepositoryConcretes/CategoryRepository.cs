using ProniaBB207.Core.Models;
using ProniaBB207.Core.RepositoryAbstracts;
using ProniaBB207.Data.DAL;

namespace ProniaBB207.Data.RepositoryConcretes;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }
}
