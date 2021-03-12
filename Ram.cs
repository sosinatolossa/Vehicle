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
        public void Turn()
        {
            Console.WriteLine("The way this ram vehicle swerved on the right turn of....");
        }
        public void Stop()
        {
            Console.WriteLine("But it stopped after because we had to catch our breath.");
            Console.WriteLine("");
        }
    }
}
