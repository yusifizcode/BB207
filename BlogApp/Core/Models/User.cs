using Core.Helpers;

namespace Core.Models
{
    public class User
    {
        static int _id;
        string _fullName;
        string _password;
        public string Fullname
        {
            get => _fullName;
            set
            {
                if (value.CheckFullName()) _fullName = value;
                else throw new FormatException("FullName duzgun daxil edilmeyib!");
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (value.CheckPassword()) _password = value;
                else throw new FormatException("Password duzgun daxil edilmeyib!");
            }
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Comment> Comments { get; set; }

        public User(string fullname, string username, string password)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Username = username;
            Password = password;
            Blogs = new List<Blog>();
            Comments = new List<Comment>();
        }
    }
}
