using BB207WebApi.Core.Modelsl;

namespace BB207WebApi.Core.Repositories;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    int Commit();

    void Add(T entity);
    void SoftDelete(T entity);
    void HardDelete(T entity);

    T Get(Func<T, bool>? func = null);
    ICollection<T> GetAll(Func<T, bool>? func = null);
}
