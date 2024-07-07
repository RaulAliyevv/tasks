namespace EFpb201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var brandRepository = new BrandRepository();
            var modelRepository = new ModelRepository();
            var colorRepository = new ColorRepository();
            var carRepository = new CarRepository();

            var bmw = brandRepository.Create(new Brand { Name = "BMW" });
            var f10 = modelRepository.Create(new Model { Name = "F10", BrandId = bmw.Id });
            var green = colorRepository.Create(new Color { Name = "Green" });
            var blue = colorRepository.Create(new Color { Name = "Blue" });
            var black = colorRepository.Create(new Color { Name = "Black" });

            var car1 = new Car
            {
                MaxSpeed = 300,
                FuelTankCapacity = 80,
                Power = 4.4m,
                DoorCount = 4,
                ModelId = f10.Id,
                Colors = new List<Color> { green, blue, black }
            };
            carRepository.Create(car1);

            PrintCarDetails(car1.Id, brandRepository, modelRepository, colorRepository, carRepository);
        }

        static void PrintCarDetails(int carId, BrandRepository brandRepository, ModelRepository modelRepository,
                                    ColorRepository colorRepository, CarRepository carRepository)
        {
            var car = carRepository.GetById(carId);

            if (car != null)
            {
                var brand = brandRepository.GetById(modelRepository.GetById(car.ModelId).BrandId);
                var model = modelRepository.GetById(car.ModelId);
                var colors = car.Colors.Select(c => c.Name);

                Console.WriteLine($"{car.Id}    {brand.Name}    {model.Name}    " +
                                  $"{car.MaxSpeed}    {car.FuelTankCapacity}    {car.Power}    " +
                                  $"{car.DoorCount}    Colors: {string.Join(", ", colors)}");
            }
        }
    }
}