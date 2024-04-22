using Core.Models;

namespace Core.Services.Abstracts
{
    public interface IUserService
    {
        void Register(User user);
        bool Login(string username, string password);
    }
}
