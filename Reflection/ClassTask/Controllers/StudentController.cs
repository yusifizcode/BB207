using ClassTask.Models;

namespace ClassTask.Controllers
{
    public class StudentController
    {
        public Group group = new Group();

        public void AddStudent()
        {
            group.StudentLimit = 10;
            Console.WriteLine("Enter student's full name: ");
            string fullname = Console.ReadLine();

            Console.WriteLine("Enter student's group no: ");
            string groupNo = Console.ReadLine();

            string avgPointStr;
            double avgPoint;
            do
            {
                Console.WriteLine("Enter student's avg point: ");
                avgPointStr = Console.ReadLine();
            } while (!double.TryParse(avgPointStr, out avgPoint));


            Student student = new Student
            {
                Fullname = fullname,
                GroupNo = groupNo,
                AvgPoint = avgPoint
            };
            group.AddStudent(student);
        }
        public void RemoveStudent()
        {
            string idStr;
            int id;
            do
            {
                Console.WriteLine("Enter student's id: ");
                idStr = Console.ReadLine();
            } while (!int.TryParse(idStr, out id));

            group.RemoveStudent(id);
        }
        public void ShowAllStudents()
        {
            foreach (var stu in group.GetAllStudents())
            {
                Console.WriteLine(stu);
            }
        }
    }
}
