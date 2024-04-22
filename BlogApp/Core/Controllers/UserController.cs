using Core.Exceptions;
using Core.Models;
using Core.Services.Concretes;

namespace Core.Controllers
{
    public class UserController
    {
        UserService userService = new UserService();

        public void Register()
        {
        RegisterSection:
            Console.WriteLine("Fullname daxil edin: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Username daxil edin: ");
            string username = Console.ReadLine();

            Console.WriteLine("Password daxil edin: ");
            string password = Console.ReadLine();

            try
            {
                User user = new User(fullName, username, password);
                userService.Register(user);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto RegisterSection;
            }
            catch (DuplicateUsernameException ex)
            {
                Console.WriteLine(ex.Message);
                goto RegisterSection;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                goto RegisterSection;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto RegisterSection;
            }
        }

        public void Login()
        {
        LoginSection:
            Console.WriteLine("Username daxil edin: ");
            string username = Console.ReadLine();

            Console.WriteLine("Password daxil edin: ");
            string password = Console.ReadLine();

            try
            {
                if (!userService.Login(username, password))
                {
                    Console.WriteLine("username ve ya password yanlishdir!");
                    goto LoginSection;
                }
                else
                {

                }
            }
            catch (UserNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                goto LoginSection;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto LoginSection;
            }
        }
    }
}
