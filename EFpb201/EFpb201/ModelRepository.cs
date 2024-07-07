namespace EFpb201;

public class ModelRepository
{
    private List<Model> _models = new List<Model>();
    private int _nextModelId = 1;

    public Model Create(Model model)
    {
        model.Id = _nextModelId++;
        _models.Add(model);
        return model;
    }

    public Model GetById(int id)
    {
        return _models.FirstOrDefault(m => m.Id == id);
    }

    public List<Model> GetAll()
    {
        return _models;
    }

    public Model Update(Model model)
    {
        var existingModel = _models.FirstOrDefault(m => m.Id == model.Id);
        if (existingModel != null)
        {
            existingModel.Name = model.Name;
            existingModel.BrandId = model.BrandId;
        }
        return existingModel;
    }

    public void Delete(int id)
    {
        var modelToRemove = _models.FirstOrDefault(m => m.Id == id);
        if (modelToRemove != null)
        {
            _models.Remove(modelToRemove);
        }
    }
}
