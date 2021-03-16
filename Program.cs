using System;
using System.Collections.Generic;

namespace TheVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() { fxs, modelS };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                ev.ChargeBattery();
            }

            /***********************************************/

            // Ram ram = new Ram();
            // Cessna cessna150 = new Cessna();

            // List <???> gasVehicles = new List<???> () {
            //     ram, cessna150
            //          };

            // Console.WriteLine("Gas Vehicles");
            // foreach (??? gv in gasVehicles)
            // {
            //     Console.WriteLine($"{gv.CurrentTankPercentage}");
            // }

            // foreach (??? gv in gasVehicles)
            // {
            //     // This should completely refuel the gas tank
            //     gv.RefuelTank();
            // }

            // foreach (??? gv in gasVehicles)
            // {
            //     Console.WriteLine($"{gv.CurrentTankPercentage}");
            // }
        }
    }
}





// static void Main(string[] args)
// {
//     //defining new objects here
//     Zero fxs = new Zero()
//     {
//         MainColor = "blue",
//         MaximumOccupancy = "2345",
//         BatteryKWh = 3.576
//     };
//     Tesla modelS = new Tesla()
//     {
//         MainColor = "red",
//         MaximumOccupancy = "4356",
//         BatteryKWh = 5.576
//     };
//     Cessna mx410 = new Cessna()
//     {
//         MainColor = "white",
//         MaximumOccupancy = "3600",
//         FuelCapacity = 1.576
//     };
//     Ram truckType5 = new Ram()
//     {
//         MainColor = "silver",
//         MaximumOccupancy = "3600",
//         FuelCapacity = 7.576
//     };

//     // calling the methods we defined in Vehicle.cs on the objects we defined above
//     fxs.Drive();
//     fxs.Turn();
//     fxs.Stop();

//     modelS.Drive();
//     modelS.Turn();
//     modelS.Stop();

//     mx410.Drive();
//     mx410.Turn();
//     mx410.Stop();

//     truckType5.Drive();
//     truckType5.Turn();
//     truckType5.Stop();
// }