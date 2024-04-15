using Core.Controllers;
using Core.Enums;

namespace MiniConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StudentController studentContoller = new StudentController();

            do
            {
                Console.WriteLine(
                              "1. Add Classroom\n" +
                              "2. Add Student\n" +
                              "3. Show Student\n" +
                              "4. Show Students for spesific classroom\n" +
                              "5. Remove Student from classroom\n" +
                              "0. Exit");
                string answerStr = Console.ReadLine();
                byte answerByte;

                while (!byte.TryParse(answerStr, out answerByte))
                {
                    Console.WriteLine("Enter the correct choice:");
                    answerStr = Console.ReadLine();
                }

                switch (answerByte)
                {
                    case (byte)Menu.AddStudent:
                        studentContoller.Add();
                        break;
                    case (byte)Menu.FindStudentById:
                        studentContoller.ShowStudent();
                        break;
                    default:
                        break;
                }

            } while (true);


        }
    }
}