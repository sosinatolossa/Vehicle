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
        public override void Drive()
        {
            Console.WriteLine("The White Cessna, that sounds like your name, flashes by you like a hurricane. Zoooooooom!");
        }
        // Overriding the Turn() method here so we can console different message
        public override void Turn()
        {
            Console.WriteLine("The white Cessna made a u trun. ");
        }
        // Overriding the Stop() method here so we can console different message
        public override void Stop()
        {
            Console.WriteLine("The white Cessna rolls to a stop after rolling a mile down the runway.");
            Console.WriteLine("");
        }
    }

}