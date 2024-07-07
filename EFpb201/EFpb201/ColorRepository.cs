namespace EFpb201;

public class ColorRepository
{
    private List<Color> _colors = new List<Color>();
    private int _nextColorId = 1;

    public Color Create(Color color)
    {
        color.Id = _nextColorId++;
        _colors.Add(color);
        return color;
    }

    public Color GetById(int id)
    {
        return _colors.FirstOrDefault(c => c.Id == id);
    }

    public List<Color> GetAll()
    {
        return _colors;
    }

    public Color Update(Color color)
    {
        var existingColor = _colors.FirstOrDefault(c => c.Id == color.Id);
        if (existingColor != null)
        {
            existingColor.Name = color.Name;
        }
        return existingColor;
    }

    public void Delete(int id)
    {
        var colorToRemove = _colors.FirstOrDefault(c => c.Id == id);
        if (colorToRemove != null)
        {
            _colors.Remove(colorToRemove);
        }
    }
}
