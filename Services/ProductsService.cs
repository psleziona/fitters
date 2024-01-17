using Fitters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters.Services
{
    public class ProductsService
    {
        List<Product> products;
        public List<Product> Products { get => products; }
        public ProductsService() 
        {
            products = FileUtility.ReadDataFromFile<List<Product>>("/products") ?? new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
            FileUtility.WriteDateToFile(products, "/products");
        }
    }
}
