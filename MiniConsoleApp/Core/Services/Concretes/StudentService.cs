using Core.DataAccessLayer;
using Core.Exceptions;
using Core.Models;
using Core.Services.Abstracts;

namespace Core.Services.Concretes
{
    public class StudentService : IStudentService
    {
        public void AddStudent(Student student)
        {
            Array.Resize(ref AppDb.Students, AppDb.Students.Length + 1);
            AppDb.Students[AppDb.Students.Length - 1] = student;
        }
        public Student FindId(int id)
        {
            foreach (Student student in AppDb.Students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }

            return null;
        }
        public void RemoveStudent(int id)
        {
            Student[] newArray = new Student[] { };

            foreach (Student student in AppDb.Students)
            {
                if (student.Id != id)
                {
                    Array.Resize(ref newArray, newArray.Length + 1);
                    newArray[newArray.Length - 1] = student;
                }
            }

            if (newArray.Length == AppDb.Students.Length)
                throw new StudentNotFoundException("Student not found");
            else
                AppDb.Students = newArray;
        }
    }
}
