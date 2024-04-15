using Core.Models;

namespace Core.Services.Abstracts
{
    public interface IStudentService
    {
        Student FindId(int id);
        void RemoveStudent(int id);
        void AddStudent(Student student);
    }
}
