using BlogAppEFBB207.Controllers;

namespace BlogAppEFBB207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CategoryController categoryController = new CategoryController();
            //categoryController.AddCategory();
            ProductController productController = new ProductController();

            productController.GetAllProducts();

        }
    }
}
