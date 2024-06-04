using BB207WebApi.Core.Modelsl;
using BB207WebApi.Core.Repositories;
using BB207WebApi.Data.DAL;

namespace BB207WebApi.Data.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    private readonly AppDbContext _context;
    public GenericRepository(AppDbContext context)
    {
        _context = context;
    }


    public int Commit()
    {
        return _context.SaveChanges();
    }
    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }
    public void HardDelete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
    public void SoftDelete(T entity)
    {
        entity.IsDeleted = true;
    }
    public T Get(Func<T, bool>? func = null)
    {
        return func == null ?
               _context.Set<T>().FirstOrDefault() :
               _context.Set<T>().Where(func).FirstOrDefault();
    }
    public ICollection<T> GetAll(Func<T, bool>? func = null)
    {
        return func == null ?
               _context.Set<T>().ToList() :
               _context.Set<T>().Where(func).ToList();
    }
}
