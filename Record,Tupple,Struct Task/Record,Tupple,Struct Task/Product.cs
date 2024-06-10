namespace Record_Tupple_Struct_Task
{
    public record Product(int Id, string Name, decimal CostPrice = 1500, decimal SalePrice = 2500)
    {
        public Product(string name, int costPrice, decimal salePrice)
        {
            Name = name;
            CostPrice = costPrice;
            SalePrice = salePrice;
        }
    }
}
