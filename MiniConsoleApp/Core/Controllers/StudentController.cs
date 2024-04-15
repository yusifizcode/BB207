using Core.Models;
using Core.Services.Abstracts;
using Core.Services.Concretes;

namespace Core.Controllers
{
    public class StudentController
    {
        IStudentService _studentService = new StudentService();

        public void Add()
        {
            Console.WriteLine("Enter student name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter student surname: ");
            string surname = Console.ReadLine();

            Student student = new Student()
            {
                Name = name,
                Surname = surname
            };

            _studentService.AddStudent(student);
        }

        public void ShowStudent()
        {
            Console.WriteLine("Enter student id: ");
            int id = int.Parse(Console.ReadLine());

            var student = _studentService.FindId(id);
            Console.WriteLine(student.Name);
        }
    }
}
