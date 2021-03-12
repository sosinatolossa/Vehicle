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
            Console.WriteLine("The White Cessna, that sounds like your name, flashes by you like a hurricane. Zoooooooom!");
        }
        public void Turn()
        {
            Console.WriteLine("The white Cessna made a u trun. ");
        }
        public void Stop()
        {
            Console.WriteLine("The white Cessna rolls to a stop after rolling a mile down the runway.");
            Console.WriteLine("");
        }
    }

}