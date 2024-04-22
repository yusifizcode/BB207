namespace Core.Models
{
    public class Blog
    {
        private static int _id;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        public List<Comment> Comments { get; set; }


        public Blog(string title, string description, int userId)
        {
            _id++;
            Id = _id;
            Title = title;
            UserId = userId;
            Description = description;
            Comments = new List<Comment>();
        }
    }
}
