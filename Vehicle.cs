using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS2A.ClassObject
{
    /// <summary>
    /// <author>Andrey</author>
    /// </summary>
    public abstract class Vehicle
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int YearOfManufacture { get; set; }
        public double CurrentSpeed { get; set; }
        public bool EngineRunning { get; set; }

    }
}