using Core.Enums;

namespace Core.Models
{
    public class Product
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public FoodType FoodType { get; set; }

        public Product()
        {
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Price} {FoodType}";
        }
    }
}
