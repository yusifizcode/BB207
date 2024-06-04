using BB207WebApi.Core.Models;
using BB207WebApi.Core.Repositories;
using BB207WebApi.Data.DAL;

namespace BB207WebApi.Data.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context) { }
}
