namespace Core.Models;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; } = null!;
    public int UserId { get; set; }
    public int BlogId { get; set; }
}
