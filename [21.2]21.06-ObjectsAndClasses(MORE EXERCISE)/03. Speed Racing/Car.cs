using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Speed_Racing
{
    class Car
    {
        public Car(string model, float fuelAmount, float fuelConsumption, float distance = 0)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.Distance = distance;
        }

        public string Model { get; set; }
        public float FuelAmount { get; set; }
        public float FuelConsumption { get; set; }
        public float Distance { get; set; }


        public void MovingCar(float distance)
        {
            float fuelNeeded = distance * this.FuelConsumption;

            if (this.FuelAmount >= fuelNeeded)
            {
                this.Distance += distance;
                this.FuelAmount -= fuelNeeded;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
