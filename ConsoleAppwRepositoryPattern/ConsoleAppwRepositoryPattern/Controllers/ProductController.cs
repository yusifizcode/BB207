using ConsoleAppwRepositoryPattern.Models;
using ConsoleAppwRepositoryPattern.Services.Abstracts;
using ConsoleAppwRepositoryPattern.Services.Concretes;

namespace ConsoleAppwRepositoryPattern.Controllers
{
    public class ProductController
    {
        IProductService _productService = new ProductService();

        public void AddProduct()
        {
            Console.WriteLine("Mehsulun adini qeyd edin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Mehsulun aciqlamasini qeyd edin: ");
            string desc = Console.ReadLine();

            string priceStr = String.Empty;
            double price;
            do
            {
                Console.WriteLine("Mehsulun qiymetini daxil edin: ");
                priceStr = Console.ReadLine();
            } while (!double.TryParse(priceStr, out price));

            string discountStr = String.Empty;
            int discount;
            do
            {
                Console.WriteLine("Mehsulun endirim faizini daxil edin: ");
                discountStr = Console.ReadLine();
            } while (!int.TryParse(discountStr, out discount));

            _productService.AddProduct(new Product(name, desc, price, discount));
        }

        public void DeleteProduct()
        {
            string idStr;
            int id;
            do
            {
                Console.WriteLine("Silmek istediyiniz mehsulun id'ni yazin: ");
                idStr = Console.ReadLine();
            } while (!int.TryParse(idStr, out id));

            _productService.DeleteProduct(id);
        }

        public void UpdateProduct()
        {
            string idStr;
            int id;
            do
            {
                Console.WriteLine("Deyishmek istediyiniz mehsulun id'ni yazin: ");
                idStr = Console.ReadLine();
            } while (!int.TryParse(idStr, out id));

            Console.WriteLine("Mehsulun adini qeyd edin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Mehsulun aciqlamasini qeyd edin: ");
            string desc = Console.ReadLine();

            string priceStr = String.Empty;
            double price;
            do
            {
                Console.WriteLine("Mehsulun qiymetini daxil edin: ");
                priceStr = Console.ReadLine();
            } while (!double.TryParse(priceStr, out price));

            string discountStr = String.Empty;
            int discount;
            do
            {
                Console.WriteLine("Mehsulun endirim faizini daxil edin: ");
                discountStr = Console.ReadLine();
            } while (!int.TryParse(discountStr, out discount));


            _productService.UpdateProduct(id, new Product(name, desc, price, discount));
        }

        public void GetAllProducts()
        {
            _productService.GetAllProducts().ForEach(prod => Console.WriteLine(prod));
        }

        public void GetProduct()
        {
            Console.WriteLine(_productService.GetProduct());
        }
    }
}
