namespace Core.Models
{
    public class Hotel
    {
        public Hotel(string name)
        {
            _id++;
            Id = _id;
            Name = name;
        }
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
    }
}
