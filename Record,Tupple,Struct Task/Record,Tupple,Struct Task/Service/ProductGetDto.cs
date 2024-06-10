namespace Record_Tupple_Struct_Task.Service
{
    public interface ProductGetDto
    {
        public record ProductGetDto(int Id, string Name, decimal SalePrice);
    }
}
