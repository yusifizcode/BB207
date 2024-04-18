namespace Reflection.Models
{
    public class Employee
    {
        private static int _id;
        public int Id { get; set; }

        private int _count = 12;

        public int Salary;
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }
        public string Surname { get; set; }


        public void ShowInfo()
        {

        }

        private int GetCount()
        {
            return _count;
        }
    }

    public class Employee2
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
    }
}
