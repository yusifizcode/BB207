namespace Core.Models;

public class Blog
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public List<Comment> Comments { get; set; }
    public int UserId { get; set; }
    public Blog()
    {
        Comments = new List<Comment>();
    }
}