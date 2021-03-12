using System;
namespace TheVehicles
{
    // Ram is a gas powered truck
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public void Drive()
        {
            Console.WriteLine("The silver Ram growls you. BZrroooooooomuble!!");
        }

    }
}
