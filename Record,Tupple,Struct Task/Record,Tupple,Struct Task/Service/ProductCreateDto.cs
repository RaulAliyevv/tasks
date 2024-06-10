namespace Record_Tupple_Struct_Task.Service
{
    public interface ProductCreateDto
    {
        string Name { get; set; }
        int CostPrice { get; init; }
        decimal SalePrice { get; init; }

        public int ProductCreateDto(string Name, decimal CostPrice, decimal SalePrice);
    }
}
