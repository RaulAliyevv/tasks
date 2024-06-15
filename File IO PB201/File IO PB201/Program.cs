namespace File_IO_PB201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();

            Product newProduct = new Product(1, "Sample Product", 50.0m, 100.0m);
            productService.Create(newProduct);

            Product retrievedProduct = productService.Get(1);
            if (retrievedProduct != null)
            {
                Console.WriteLine($"Product found: {retrievedProduct.Name}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }

            List<Product> allProducts = productService.GetAll();
            Console.WriteLine("All Products:");
            foreach (var product in allProducts)
            {
                Console.WriteLine($"{product.Id} - {product.Name}");
            }

            productService.Delete(1);
            Console.WriteLine("Product deleted.");

            Product deletedProduct = productService.Get(1);
            if (deletedProduct == null)
            {
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Product {deletedProduct.Name} still exists.");
            }
        }
    }
}
