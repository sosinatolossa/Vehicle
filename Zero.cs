using System;
namespace TheVehicles
{
    // Zero is electric motorcycle
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine("The Midnight Blue Zero zips by you. Vroom Vroooom!");
        }
    }

}