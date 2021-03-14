using System;

namespace TheVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "white",
                MaximumOccupancy = "2345",
                BatteryKWh = 3.576
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "green",
                MaximumOccupancy = "4356",
                BatteryKWh = 5.576
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "black",
                MaximumOccupancy = "3600",
                BatteryKWh = 1.576
            };
            Ram truckType5 = new Ram()
            {
                MainColor = "yellow",
                MaximumOccupancy = "3600",
                BatteryKWh = 7.576
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
