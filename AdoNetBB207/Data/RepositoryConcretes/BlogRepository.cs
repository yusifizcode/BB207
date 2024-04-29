using Core.Models;
using Core.RepositoryAbstracts;

namespace Data.RepositoryConcretes;

public class BlogRepository : GenericRepository<Blog>, IBlogRepository
{
    public void BlogTest()
    {
        throw new NotImplementedException();
    }
}
