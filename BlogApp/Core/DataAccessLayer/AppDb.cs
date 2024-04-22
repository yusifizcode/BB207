using Core.Models;

namespace Core.DataAccessLayer
{
    public class AppDb
    {
        public static List<Blog> Blogs { get; set; } = new List<Blog>();
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
