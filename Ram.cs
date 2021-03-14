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
        public override void Drive()
        {
            Console.WriteLine("The silver Ram growls you. BZrroooooooomuble!!");
        }
        // Overriding the Turn() method here so we can console different message
        public override void Turn()
        {
            Console.WriteLine("The way this ram vehicle swerved on the right turn of....");
        }
        // Overriding the Stop() method here so we can console different message
        public override void Stop()
        {
            Console.WriteLine("But it stopped after because we had to catch our breath.");
            Console.WriteLine("");
        }
    }
}
