using Core.Enums;

namespace Core.Models
{
    public class Classroom
    {
        private static int _id;
        public int Id { get; set; }
        public Classroom()
        {
            _id++;
            Id = _id;
        }
        public string Name { get; set; }
        public ClassroomType ClassType { get; set; }
    }
}
