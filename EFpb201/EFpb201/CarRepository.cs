namespace EFpb201;

public class CarRepository
{
    private List<Car> _cars = new List<Car>();
    private int _nextCarId = 1;

    public Car Create(Car car)
    {
        car.Id = _nextCarId++;
        _cars.Add(car);
        return car;
    }

    public Car GetById(int id)
    {
        return _cars.FirstOrDefault(c => c.Id == id);
    }

    public List<Car> GetAll()
    {
        return _cars;
    }

    public Car Update(Car car)
    {
        var existingCar = _cars.FirstOrDefault(c => c.Id == car.Id);
        if (existingCar != null)
        {
            existingCar.MaxSpeed = car.MaxSpeed;
            existingCar.FuelTankCapacity = car.FuelTankCapacity;
            existingCar.Power = car.Power;
            existingCar.DoorCount = car.DoorCount;
            existingCar.ModelId = car.ModelId;
            existingCar.Colors = car.Colors; 
        }
        return existingCar;
    }

    public void Delete(int id)
    {
        var carToRemove = _cars.FirstOrDefault(c => c.Id == id);
        if (carToRemove != null)
        {
            _cars.Remove(carToRemove);
        }
    }
}
