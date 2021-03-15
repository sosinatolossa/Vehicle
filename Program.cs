using System;

namespace TheVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "blue",
                MaximumOccupancy = "2345",
                BatteryKWh = 3.576
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "red",
                MaximumOccupancy = "4356",
                BatteryKWh = 5.576
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "white",
                MaximumOccupancy = "3600",
                FuelCapacity = 1.576
            };
            Ram truckType5 = new Ram()
            {
                MainColor = "silver",
                MaximumOccupancy = "3600",
                FuelCapacity = 7.576
            };

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();

            truckType5.Drive();
            truckType5.Turn();
            truckType5.Stop();

        }
    }
}
