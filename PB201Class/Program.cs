namespace PB201Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Car car = new Car();
            car.CurrentFuel = 80;
            car.FuelFor1Km = 4;
            car.Model = "MercedesBenz";
            car.Brand = "2023";

            car.Drive(5);


            car.ShowFullData();


            
        }
    }
}
