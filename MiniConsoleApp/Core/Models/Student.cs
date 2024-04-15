namespace Core.Models
{
    public class Student
    {
        private static int _id;
        public int Id { get; set; }
        public Student()
        {
            _id++;
            Id = _id;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
