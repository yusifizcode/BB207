using Eflyer.Core.Models;

namespace Eflyer.Core.RepositoryAbstracts;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    void Add(T entity);
    void Delete(T entity);
    int Commit();
    Task<int> CommitAsync();

    T Get(Func<T, bool>? func = null);
    List<T> GetAll(int page = 1, Func<T, bool>? func = null);
}
