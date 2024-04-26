namespace ConsoleAppwRepositoryPattern.Models
{
    public class Product
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int DiscountPercent { get; set; }

        public Product(string name, string desc, double price, int discount)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            Description = desc;
            DiscountPercent = discount;
        }

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Price: {Price}\n" +
                   $"Description: {Description}\n" +
                   $"DiscountPercent: {DiscountPercent}";
        }
    }
}
