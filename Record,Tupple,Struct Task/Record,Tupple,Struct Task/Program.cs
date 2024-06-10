using Record_Tupple_Struct_Task.Service;

internal class Program
{
    public static int CostPrice { get; private set; }
    public static int SalePrice { get; private set; }
    public static string Name { get; private set; }

    private static void Main(string[] args, ProductCreateDto newProductDto)
    {
        ProductService productService = new();
        {
            Name = "New Product";
            CostPrice = 2000;
            SalePrice = 3000;
        };
        productService.Create(newProductDto);

        var allProducts = productService.GetAll();
        foreach (var productTuple in allProducts)
        {
            Console.WriteLine($"Product Id: {productTuple.Item1}, Name: {productTuple.Item2}, SalePrice: {productTuple.Item3}");
        }
    }
}