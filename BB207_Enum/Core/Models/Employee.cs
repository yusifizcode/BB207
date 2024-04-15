namespace Core.Models
{
    public class Employee
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public Employee()
        {
            _id++;
            Id = _id;
        }


        public override string ToString()
        {
            return $"Id: {Id}; Name: {Name}; Surname: {Surname}; Position: {Position}";
        }
    }
}
