using System;
namespace TheVehicles
{
    // Cessna is Propellor light aircraft
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public void Drive()
        {
            Console.WriteLine("Zoooooooom!");
        }
    }

}