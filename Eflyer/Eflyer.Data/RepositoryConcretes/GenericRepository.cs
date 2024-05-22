using Eflyer.Core.Models;
using Eflyer.Core.RepositoryAbstracts;
using Eflyer.Data.DAL;

namespace Eflyer.Data.RepositoryConcretes;

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

    public Task<int> CommitAsync()
    {
        return _context.SaveChangesAsync();
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

    public List<T> GetAll(int page = 1, Func<T, bool>? func = null)
    {
        return func == null ?
               _context.Set<T>().Skip((page - 1) * 2).Take(2).ToList() :
               _context.Set<T>().Where(func).Skip((page - 1) * 2).Take(2).ToList();
    }
}
