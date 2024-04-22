using Core.Models;

namespace Core.Services.Abstracts
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);
        Blog GetBlog(Predicate<Blog>? predicate);
        List<Blog> GetAllBlogs(Predicate<Blog>? predicate);
    }
}
