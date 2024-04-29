using Business.Services.Abstracts;
using Business.Services.Concretes;
using Core.Models;

namespace AdoNetBB207.Controllers;

public class BlogController
{
    IBlogService _blogService = new BlogService();

    public void CreateBlog()
    {
        Console.WriteLine("Enter blog title: ");
        string title = Console.ReadLine();

        Console.WriteLine("Enter blog desc: ");
        string desc = Console.ReadLine();

        Console.WriteLine("Enter user id: ");
        int userId = int.Parse(Console.ReadLine());

        Blog blog = new Blog
        {
            Title = title,
            Description = desc,
            UserId = userId
        };

        _blogService.Add(blog);
    }

    public void DeleteBlog()
    {
        Console.WriteLine("Enter blog id: ");
        int blogId = int.Parse(Console.ReadLine());

        _blogService.Delete(blogId);
    }
}
