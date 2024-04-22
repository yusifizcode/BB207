namespace Core.Models
{
    public class Comment
    {
        private static int _id;
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? BlogId { get; set; }
        public string Content { get; set; }

        public Comment(int blogId, int userId, string content)
        {
            _id++;
            Id = _id;
            BlogId = blogId;
            UserId = userId;
            Content = content;
        }
    }
}
