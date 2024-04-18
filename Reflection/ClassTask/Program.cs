using ClassTask.Controllers;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StudentController studentController = new StudentController();

            string answer = String.Empty;
            do
            {
                Console.WriteLine("1. Add Student\n" +
                                  "2. Remove Student\n" +
                                  "3. Show all Students\n" +
                                  "0. Exit");

                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        studentController.AddStudent();
                        break;
                    case "2":
                        studentController.RemoveStudent();
                        break;
                    case "3":
                        studentController.ShowAllStudents();
                        break;
                    default:
                        break;
                }


            } while (answer != "0");
        }
    }
}