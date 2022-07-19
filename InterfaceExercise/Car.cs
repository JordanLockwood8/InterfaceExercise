using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle , ICompany
    {
        public bool HasTrunk { get; set; }
        public int SpeedMph { get; set; }
        public string Logo { get; set; }
        public string NameOfCompany { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfWindows { get; set; }
        public string Color { get; set; }
        public bool Automatic { get; set; }
    }
}
