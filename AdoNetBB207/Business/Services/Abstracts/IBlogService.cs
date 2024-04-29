using Core.Models;

namespace Business.Services.Abstracts
{
    public interface IBlogService
    {
        void Add(Blog blog);
        void Delete(int id);
        void Update(int id, Blog blog);
        Blog Get(int id);
        List<Blog> GetAll();
    }
}
