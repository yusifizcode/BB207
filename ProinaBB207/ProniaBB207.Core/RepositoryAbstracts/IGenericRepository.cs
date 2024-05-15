using ProniaBB207.Core.Models;

namespace ProniaBB207.Core.RepositoryAbstracts;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    void Add(T entity);
    void Delete(T entity);

    T Get(Func<T, bool>? func = null);
    List<T> GetAll(Func<T, bool>? func = null);

    int Commit();
}
