using BasicDotNetApi.Models;

namespace BasicDotNetApi.Services
{
    public class ProductService
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 50000 },
            new Product { Id = 2, Name = "Phone", Price = 20000 }
        };

        public List<Product> GetAll()
        {
            return products;
        }

        public Product? GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
        }
    }
}
