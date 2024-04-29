using System.Data;

namespace Core.RepositoryAbstracts;

public interface IGenericRepository<T> where T : class, new()
{
    void Add(string command);
    void Delete(string command);
    DataTable Get(int id, string tableName);
    DataTable GetAll(string tableName);
}
