using Eflyer.Core.Models;
using Eflyer.Core.RepositoryAbstracts;
using Eflyer.Data.DAL;

namespace Eflyer.Data.RepositoryConcretes;

public class ElectronicRepository : GenericRepository<Electronic>, IElectronicRepository
{
    public ElectronicRepository(AppDbContext context) : base(context)
    {
    }
}
