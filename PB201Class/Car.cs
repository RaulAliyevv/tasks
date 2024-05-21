using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Class
{
    public class Car
    {
        public double CurrentFuel;
        public double FuelFor1Km;
        public string Model;
        public string Brand;


        public void Drive(int km) 
        {
            Console.WriteLine(CurrentFuel = CurrentFuel - (FuelFor1Km * km));
        }

        public void ShowFullData() 
        {
            Console.WriteLine($"{Brand} - {Model} - {CurrentFuel} - {FuelFor1Km}");
        }

        public string GetFullData() 
        {
            return $"{Brand} - {Model} - {CurrentFuel} - {FuelFor1Km}";
        }


    }
}
