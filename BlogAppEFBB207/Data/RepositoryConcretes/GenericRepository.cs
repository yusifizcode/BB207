using Core.RepositoryAbstracts;
using Data.DAL;
using Microsoft.EntityFrameworkCore;

namespace Data.RepositoryConcretes;

public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
{
    AppDbContext _dbContext;
    public GenericRepository()
    {
        _dbContext = new AppDbContext();
    }
    public void Add(T entity)
    {
        _dbContext.Set<T>().Add(entity);
    }

    public int Commit()
    {
        return _dbContext.SaveChanges();
    }

    public void Delete(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
    }

    public T Get(Func<T, bool>? predicate, params string[] includes)
    {
        //if (predicate == null)
        //{
        //    return _dbContext.Set<T>().FirstOrDefault();
        //}
        //else
        //{
        //    return _dbContext.Set<T>().Find(predicate);
        //}         
        // select* from Products
        // left join Categories
        // ON Products.CategoryId = Categories.Id
        var entity = _dbContext.Set<T>().AsQueryable();
        if (includes != null)
        {
            foreach (var include in includes)
            {
                entity = entity.Include(include);
            }
        }

        return predicate == null ?
               _dbContext.Set<T>().FirstOrDefault() :
               _dbContext.Set<T>().FirstOrDefault(predicate);
    }

    public List<T> GetAll(Func<T, bool>? predicate, params string[] includes)
    {
        var entity = _dbContext.Set<T>().AsQueryable();
        if (includes != null)
        {
            foreach (var include in includes)
            {
                entity = entity.Include(include);
            }
        }

        return predicate == null ?
               entity.ToList() :
               entity.Where(predicate).ToList();
    }
}
