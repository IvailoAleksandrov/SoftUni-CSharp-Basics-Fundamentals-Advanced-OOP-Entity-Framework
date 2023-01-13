using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); 
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>(); 

            while (input != "end")
            {
                string[] commands = input.Split('/');
                string type = commands[0];
                string brand = commands[1];
                string model = commands[2];
                int horsePowerOrWeight = int.Parse(commands[3]);

                if (commands[0] == "Car")
                {
                    Car car = new Car(brand, model, horsePowerOrWeight);
                    cars.Add(car);
                }

                else if (commands[0] == "Truck")
                {
                    Truck truck = new Truck(brand, model, horsePowerOrWeight);
                    trucks.Add(truck);
                }

                input= Console.ReadLine();
            }

            List<Car> orderedCars = cars.OrderBy(c => c.Brand).ToList();
            List<Truck> orderedTrucks = trucks.OrderBy(c => c.Brand).ToList();
            
            if (cars.Count > 0 )
            {
                Console.WriteLine("Cars:");
                foreach (Car car in orderedCars)
                {
                    
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderedTrucks)
                {
                    
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }

            }

        }
    }
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
    
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
    
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

}
