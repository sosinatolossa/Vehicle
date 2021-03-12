using System;

namespace TheVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram truckType5 = new Ram();

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            truckType5.Drive();
        }
    }
}
