using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string carModel = input[0];
                float fuelAmount = float.Parse(input[1]);
                float fuelConsumption = float.Parse(input[2]);

                cars.Add(new Car(carModel, fuelAmount, fuelConsumption));
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");

                if (input[0] == "End")
                {
                    break;
                }

                string carModel = input[1];
                float distanceKm = float.Parse(input[2]);

                cars.Find(c => c.Model == carModel).MovingCar(distanceKm);
            }

            foreach (var car in cars)
            {

                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.Distance}");
            }
        }
    }
}
