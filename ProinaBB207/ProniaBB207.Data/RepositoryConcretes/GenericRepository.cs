using ProniaBB207.Core.Models;
using ProniaBB207.Core.RepositoryAbstracts;
using ProniaBB207.Data.DAL;

namespace ProniaBB207.Data.RepositoryConcretes;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    private readonly AppDbContext _context;
    public GenericRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public int Commit()
    {
        return _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public T Get(Func<T, bool>? func = null)
    {
        return func == null ?
               _context.Set<T>().FirstOrDefault() :
               _context.Set<T>().FirstOrDefault(func);
    }

    public List<T> GetAll(Func<T, bool>? func = null)
    {
        return func == null ?
               _context.Set<T>().ToList() :
               _context.Set<T>().Where(func).ToList();
    }
}
