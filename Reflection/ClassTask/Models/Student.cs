namespace ClassTask.Models
{
    public class Student
    {
        public string Fullname { get; set; }
        private static int _id;
        public int Id { get; set; }

        private string _groupNo;
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (value.Length == 5 && char.IsUpper(value[0]) && char.IsUpper(value[1]) &&
                    char.IsDigit(value[2]) && char.IsDigit(value[3]) && char.IsDigit(value[4]))
                {
                    _groupNo = value;
                }
            }
        }
        public double AvgPoint { get; set; }

        public Student()
        {
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nFullName: {Fullname}\nGroupNo: {GroupNo}\nAvgPoint: {AvgPoint}";
        }
    }
}
