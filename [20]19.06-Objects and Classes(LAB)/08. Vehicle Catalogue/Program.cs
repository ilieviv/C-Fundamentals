using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> allCars = new List<Car>();
            List<Truck> allTrucks = new List<Truck>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("/");

                if (input[0] == "end")
                {
                    break;
                }

                string typeVehicle = input[0];
                string brand = input[1];
                string model = input[2];
                int weightOrHorsePower = int.Parse(input[3]);



                if (typeVehicle == "Car")
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = weightOrHorsePower;
                    allCars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weightOrHorsePower;
                    allTrucks.Add(truck);
                }

            }

            var newListCars = allCars.OrderBy(x => x.Brand);
            
            var newListTrucks = allTrucks.OrderBy(x => x.Brand);

            if (allCars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }

            foreach (Car carItem in newListCars)
            {
                Console.WriteLine($"{carItem.Brand}: {carItem.Model} - {carItem.HorsePower}hp");
            }

            if (allTrucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }

            foreach (Truck truckItem in newListTrucks)
            {
                Console.WriteLine($"{truckItem.Brand}: {truckItem.Model} - {truckItem.Weight}kg");
            }


        }
    }
}
