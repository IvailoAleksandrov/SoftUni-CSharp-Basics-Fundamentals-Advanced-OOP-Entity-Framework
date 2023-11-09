using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            int n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                string[] carDate = Console.ReadLine().Split();
                string model = carDate[0];
                double fuel = double.Parse(carDate[1]);
                double consum = double.Parse(carDate[2]);

                if (!cars.ContainsKey(model))
                {
                    Car car = new Car(model, fuel, consum);
                    cars[car.Model] = car;
                }
                
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] driveData = command.Split();
                string model = driveData[1];
                double distance = double.Parse(driveData[2]);

                KeyValuePair<string, Car> car = cars.FirstOrDefault(c => c.Key == model);
                if (car.Key != null)
                {
                    cars[model].Drive(distance);
                }

            }
            Console.WriteLine(String.Join(Environment.NewLine, cars.Values));
        }
    }
}
