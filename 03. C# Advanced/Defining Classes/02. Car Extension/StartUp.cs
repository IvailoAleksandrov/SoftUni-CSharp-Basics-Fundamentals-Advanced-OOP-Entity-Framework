using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           Car car = new Car();
            car.Make = "Ivo";
            car.Model = "S3";
            car.Year= 1;
            car.FuelQuantity = 62;
            car.FuelConsumption = 7.5;
            car.Drive(202.40);
            car.Drive(500);
            Console.WriteLine(car.WhoAmI());


        }
    }
}
