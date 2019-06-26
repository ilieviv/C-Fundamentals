﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Vehicle_Catalogue
{
    class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
