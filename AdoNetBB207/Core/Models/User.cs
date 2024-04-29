namespace Core.Models;

public class User
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public List<Blog> Blogs { get; set; }
    public List<Comment> Comments { get; set; }

    public User()
    {
        Blogs = new List<Blog>();
        Comments = new List<Comment>();
    }
}