using Core.Enums;
using Core.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Product product = new Product
            {
                Name = "Coca Cola",
                Price = 2,
                FoodType = FoodType.Drink
            };

            Product product1 = new Product
            {
                Name = "Makaron",
                Price = 5,
                FoodType = FoodType.Diary
            };

            Product product2 = new Product
            {
                Name = "Tort",
                Price = 25,
                FoodType = FoodType.Baker
            };

            store.AddProduct(product);
            store.AddProduct(product1);
            store.AddProduct(product2);

            Console.WriteLine("1. Baker " +
                               "2. Drink" +
                               "3. Meat" +
                               "4. Diary"
                               );


            Console.WriteLine("Choose one:");

            string choiceStr = Console.ReadLine();
            int choiceInt = int.Parse(choiceStr);


            Product[] arr = store.FilterProductsByType((FoodType)choiceInt);
            //Product[] arr1 = store.FilterProductByName("cola");

            foreach (Product pr in arr)
            {
                Console.WriteLine(pr);
            };
        }
    }
}