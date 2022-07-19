using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var car1 = new Car()
            {
                HasTrunk = true,
                SpeedMph = 200,
                Automatic = true,
                Color = "red",
                NameOfCompany = "Jaguire",
                Logo = "Jag standing",
                NumberOfWheels = 4,
                NumberOfWindows = 4,

            };
            var truck1 = new Truck()
            {
                BedLength = 45,
                HasHitch = true,
                Automatic = true,
                Color = "blue",
                NameOfCompany = "Ford",
                Logo = "F",
                NumberOfWheels = 6,
                NumberOfWindows = 4,
            };
            var suv1 = new Suv()
            {
                HasFourWheelDrive = true,
                SeatsNumber = 5,
                Automatic = true,
                Color = "white",
                NameOfCompany = "jeep",
                Logo = "Jeep Written",
                NumberOfWindows = 6,
                NumberOfWheels = 4,
            };
            var vList = new List<IVehicle>();
            vList.Add(car1);
            vList.Add(truck1);
            vList.Add(suv1);
            foreach (var vehicle in vList)
            {
                Console.WriteLine($"Number of Windows:{vehicle.NumberOfWindows}\n Number of wheels:{vehicle.NumberOfWheels}\n"+
                    $"Is Automatic:{vehicle.Automatic}\n This vehicle is:{vehicle.Color}\n Company{vehicle.NameOfCompany}\n" +
                    $"Logo:{vehicle.Logo}");
                if (vehicle == car1)
                {
                    Console.WriteLine($"Has Trunk: {car1.HasTrunk}");
                    Console.WriteLine($"SpeedMph: {car1.SpeedMph}");
                }
                else if (vehicle == truck1)
                {
                    Console.WriteLine($"Bed Length:{truck1.BedLength}\n Has a Hitch:{truck1.HasHitch}");
                    
                }
                else if (vehicle == suv1)
                {
                    Console.WriteLine($"Has 4 Wheel Drive:{suv1.HasFourWheelDrive}\n Seat Number:{suv1.SeatsNumber}");
                }
                    
                Console.WriteLine("");
            }
            
        }
    }
}
