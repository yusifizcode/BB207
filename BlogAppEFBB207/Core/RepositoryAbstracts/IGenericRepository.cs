namespace Core.RepositoryAbstracts;

public interface IGenericRepository<T> where T : class, new()
{
    void Add(T entity);
    void Delete(T entity);

    T Get(Func<T, bool>? predicate, params string[] includes);
    List<T> GetAll(Func<T, bool>? predicate, params string[] includes);
    int Commit();
}
