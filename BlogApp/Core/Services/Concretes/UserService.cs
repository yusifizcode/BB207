using Core.DataAccessLayer;
using Core.Exceptions;
using Core.Models;
using Core.Services.Abstracts;

namespace Core.Services.Concretes
{
    public class UserService : IUserService
    {
        public bool Login(string username, string password)
        {
            User user = AppDb.Users.FirstOrDefault(user => user.Username == username);

            if (user == null) throw new UserNotFoundException("username ve ya password yanlishdir!");
            if (user.Password != password) return false;
            return true;
        }

        public void Register(User user)
        {
            if (user == null) throw new NullReferenceException("user null ola bilmez!");
            if (AppDb.Users.Any(u => u.Username == user.Username))
                throw new DuplicateUsernameException($"{user.Username} username'i movcuddur!");

            AppDb.Users.Add(user);
        }
    }
}
