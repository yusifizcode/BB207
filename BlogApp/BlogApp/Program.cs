using Core.Controllers;
using Core.Enums;

namespace BlogApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserController userController = new UserController();
            do
            {
                string ans;
                int ansInt;

                do
                {
                    Console.WriteLine("1. Register\n" +
                                      "2. Login");
                    ans = Console.ReadLine();
                } while (!int.TryParse(ans, out ansInt));

                switch (ansInt)
                {
                    case (int)Menu.Register:
                        userController.Register();
                        break;
                    case (int)Menu.Login:
                        userController.Login();
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}