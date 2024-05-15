﻿using PustokAB204.Core.Models;
using PustokAB204.Core.RepositoryAbstracts;
using PustokAB204.Data.DAL;

namespace PustokAB204.Data.RepositoryConcretes;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    private readonly AppDbContext _appDbContext;
    public GenericRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task AddAsync(T entity)
    {
        await _appDbContext.Set<T>().AddAsync(entity);
    }

    public int Commit()
    {
        return _appDbContext.SaveChanges();
    }

    public async Task<int> CommitAsync()
    {
        return await _appDbContext.SaveChangesAsync();
    }

    public void Delete(T entity)
    {
        _appDbContext.Set<T>().Remove(entity);
    }

    public List<T> GetAll(Func<T, bool>? func = null)
    {
        return func == null ?
               _appDbContext.Set<T>().ToList() :
               _appDbContext.Set<T>().Where(func).ToList();
    }

    public T Get(Func<T, bool>? func = null)
    {
        return func == null ?
               _appDbContext.Set<T>().FirstOrDefault() :
               _appDbContext.Set<T>().FirstOrDefault(func);
    }
}
