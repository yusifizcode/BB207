using Core.Enums;

namespace Core.Models
{
    public class Store
    {
        Product[] _products;

        public Store()
        {
            _products = new Product[0];
        }

        public void AddProduct(Product product)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }

        public void RemoveProductByNo(int id)
        {
            Product[] newProducts = { };
            foreach (Product product in _products)
            {
                if (product.Id != id)
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = product;
                }
            }

            _products = newProducts;
        }

        public Product[] FilterProductsByType(FoodType type)
        {
            Product[] newProducts = { };
            foreach (Product product in _products)
            {
                if (product.FoodType == type)
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = product;
                }
            }

            return newProducts;
        }

        public Product[] FilterProductByName(string name)
        {
            Product[] newProducts = { };
            foreach (Product product in _products)
            {
                if (product.Name.ToLower().Contains(name.ToLower()))
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = product;
                }
            }

            return newProducts;
        }
    }
}
