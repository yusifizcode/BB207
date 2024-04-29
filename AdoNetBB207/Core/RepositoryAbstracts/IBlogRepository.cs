using Core.Models;

namespace Core.RepositoryAbstracts;

public interface IBlogRepository : IGenericRepository<Blog>
{
    public void BlogTest();
}
