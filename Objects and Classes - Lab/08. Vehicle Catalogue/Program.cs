using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Program
    {
        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public double Weight { get; set; }
        }
        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
        class Catalog
        {
            public List<Car> CarsCatalog { get; set; }
            public List<Truck> TrucksCatalog { get; set; }
        }
        static void Main(string[] args)
        {
            string commandLine = Console.ReadLine();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while (commandLine != "end")
            {
                string[] tokens = commandLine.Split('/');
                if (tokens[0] == "Car")
                {
                    string brand = tokens[1];
                    string model = tokens[2];
                    int horsePower = int.Parse(tokens[3]);
                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower
                    };
                    cars.Add(car);
                }

                if (tokens[0] == "Truck")
                {
                    string brand = tokens[1];
                    string model = tokens[2];
                    double weight = double.Parse(tokens[3]);
                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight,
                    };
                    trucks.Add(truck);
                }
                commandLine = Console.ReadLine();
            }
            List<Car> reCollectCars = cars.OrderBy(o => o.Brand).ToList();
            List<Truck> reCollectTrucks = trucks.OrderBy(o => o.Brand).ToList();
            Console.WriteLine("Cars:");
            foreach (Car car in reCollectCars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (Truck truck in reCollectTrucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
