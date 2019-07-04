using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Raw_Data
{
    class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }
        public int CargoWeight { get; set; }

        public string CargoType { get; set; }
    }
}
