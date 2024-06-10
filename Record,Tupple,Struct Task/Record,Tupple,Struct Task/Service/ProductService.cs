namespace Record_Tupple_Struct_Task.Service
{
    public class ProductService
    {
        private List<Product> products = new List<Product>();

        public void Create(ProductCreateDto productCreateDto)
        {
            Product newProduct = new(productCreateDto.Name, productCreateDto.CostPrice, productCreateDto.SalePrice);
            products.Add(newProduct);
            Console.WriteLine($"Product '{newProduct.Name}' created with SalePrice: {newProduct.SalePrice}");
        }

        public (int, string, decimal) Get(int id)
        {
            Product product = products.Find(p => p.Id == id);
            if (product == null)
            {
                return (0, null, 0); 
            }
            return (product.Id, product.Name, product.SalePrice);
        }

        public List<(int, string, decimal)> GetAll()
        {
            List<(int, string, decimal)> productTuples = new List<(int, string, decimal)>();
            foreach (Product product in products)
            {
                productTuples.Add((product.Id, product.Name, product.SalePrice));
            }
            Console.WriteLine("All products retrieved successfully.");
            return productTuples;
        }

        public void Delete(int id)
        {
            Product product = products.Find(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}