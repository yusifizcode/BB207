using AdoNetBB207.Controllers;

namespace AdoNetBB207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlogController blogController = new BlogController();

            blogController.CreateBlog();

            blogController.DeleteBlog();
        }
    }
}