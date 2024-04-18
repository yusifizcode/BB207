namespace ClassTask.Models
{
    public class Group
    {
        public string No { get; set; }
        MyList<Student> Students = new MyList<Student>();
        public int StudentLimit { get; set; }

        public void AddStudent(Student student)
        {
            if (Students.Length < StudentLimit)
            {
                Students.Add(student);
            }
            else
            {
                Console.WriteLine("Limit ashildi");
            }
        }
        public void RemoveStudent(int id)
        {
            foreach (var student in Students.GetAllValues())
            {
                if (student.Id == id)
                {
                    Students.Remove(student);
                }
            }

        }
        public Student[] GetAllStudents()
        {
            return Students.GetAllValues();
        }
    }
}
