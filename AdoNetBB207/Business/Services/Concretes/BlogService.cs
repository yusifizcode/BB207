using Business.Services.Abstracts;
using Core.Models;
using Core.RepositoryAbstracts;
using Data.RepositoryConcretes;

namespace Business.Services.Concretes
{
    public class BlogService : IBlogService
    {
        IBlogRepository _repository = new BlogRepository();

        public void Add(Blog blog)
        {
            string command = "Insert Into Blogs (Title, Description, UserId)" +
                             $" Values ('{blog.Title}','{blog.Description}',{blog.UserId})";

            _repository.Add(command);
        }

        public void Delete(int id)
        {
            string command = $"DELETE FROM Blogs WHERE Id = {id}";
            _repository.Delete(command);
        }

        public Blog Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
