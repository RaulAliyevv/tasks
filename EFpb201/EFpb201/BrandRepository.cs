namespace EFpb201;

public class BrandRepository
{
    private List<Brand> _brands = new List<Brand>();
    private int _nextBrandId = 1;

    public Brand Create(Brand brand)
    {
        brand.Id = _nextBrandId++;
        _brands.Add(brand);
        return brand;
    }

    public Brand GetById(int id)
    {
        return _brands.FirstOrDefault(b => b.Id == id);
    }

    public List<Brand> GetAll()
    {
        return _brands;
    }

    public Brand Update(Brand brand)
    {
        var existingBrand = _brands.FirstOrDefault(b => b.Id == brand.Id);
        if (existingBrand != null)
        {
            existingBrand.Name = brand.Name;
        }
        return existingBrand;
    }

    public void Delete(int id)
    {
        var brandToRemove = _brands.FirstOrDefault(b => b.Id == id);
        if (brandToRemove != null)
        {
            _brands.Remove(brandToRemove);
        }
    }
}
