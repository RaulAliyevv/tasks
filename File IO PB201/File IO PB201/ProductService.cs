using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace File_IO_PB201
{
    public class ProductService
    {
        private string filePath = "products.json";

        public object JsonConvert { get; private set; }

        public void Create(Product product)
        {
            List<Product> products = GetAllProducts();
            products.Add(product);
            SaveProductsToFile(products);
        }

        public Product Get(int id)
        {
            List<Product> products = GetAllProducts();
            return products.Find(p => p.Id == id);
        }

        public List<Product> GetAll()
        {
            return GetAllProducts();
        }

        public void Delete(int id)
        {
            List<Product> products = GetAllProducts();
            products.RemoveAll(p => p.Id == id);
            SaveProductsToFile(products);
        }

        private List<Product> GetAllProducts()
        {
            if (!File.Exists(filePath))
            {
                return new List<Product>();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }

        private void SaveProductsToFile(List<Product> products)
        {
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
