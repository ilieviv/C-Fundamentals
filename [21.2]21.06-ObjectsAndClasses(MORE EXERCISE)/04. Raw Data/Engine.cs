using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Raw_Data
{
    class Engine
    {

        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
}
