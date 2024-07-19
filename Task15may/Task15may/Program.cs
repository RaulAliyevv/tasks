namespace Task15may
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Məhsul 1", Price = 10.5, StokSayısı = 100 },
            new Product { Id = 2, Name = "Məhsul 2", Price = 15.75, StokSayısı = 80 },
            new Product { Id = 3, Name = "Məhsul 3", Price = 20.0, StokSayısı = 120 },
            new Product { Id = 4, Name = "Məhsul 4", Price = 8.25, StokSayısı = 150 },
            new Product { Id = 5, Name = "Məhsul 5", Price = 12.0, StokSayısı = 90 },
            new Product { Id = 6, Name = "Məhsul 6", Price = 25.5, StokSayısı = 110 }
        };

            double averagePrice = products.Where(p => p.Id % 2 == 1).Average(p => p.Price);

            Console.WriteLine($"Tək Id-ləri olan məhsulların Price'larının ədədi ortası: {averagePrice}");
        }
    }
}
