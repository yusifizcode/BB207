using Core.DataAccessLayer;
using Core.Models;
using Core.Services.Abstracts;

namespace Core.Services.Concretes
{
    public class BlogService : IBlogService
    {
        public void AddBlog(Blog blog)
        {
            if (blog == null) throw new NullReferenceException("blog null ola bilmez!");
            if (blog.UserId == null) throw new NullReferenceException("UserId null ola bilmez!");
            User user = AppDb.Users.FirstOrDefault(user => user.Id == blog.UserId);

            if (user == null) throw new NullReferenceException("User yoxdur!");

            user.Blogs.Add(blog);
            AppDb.Blogs.Add(blog);
        }

        public List<Blog> GetAllBlogs(Predicate<Blog>? predicate)
        {
            return predicate != null ?
                   AppDb.Blogs.FindAll(predicate) :
                   AppDb.Blogs;
        }

        public Blog GetBlog(Predicate<Blog>? predicate)
        {
            return predicate != null ?
                   AppDb.Blogs.Find(predicate) :
                   AppDb.Blogs.Find(x => true);
        }
    }
}
