using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int BedLength { get; set; }
        public bool HasHitch { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfWindows { get; set; }
        public string Color { get; set; }
        public bool Automatic { get; set; }
        public string Logo { get; set; }
        public string NameOfCompany { get; set; }
    }
}
