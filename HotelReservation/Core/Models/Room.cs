namespace Core.Models
{
    public class Room
    {
        public Room(string name, double price, byte personCapacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }

        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public byte PersonCapacity { get; set; }
        public bool IsAvialable { get; set; } = true;

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\n" +
                   $"Price: {Price}\n" +
                   $"PersonCapacity: {PersonCapacity}\n" +
                   $"IsAvialable: {IsAvialable}";
        }
    }
}
