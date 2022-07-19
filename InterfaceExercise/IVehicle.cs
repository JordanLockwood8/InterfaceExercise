using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfWindows { get; set; }
        public string Color { get; set; }
        public bool Automatic { get; set; }
    }
}
