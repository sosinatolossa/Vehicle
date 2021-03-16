using System;
namespace TheVehicles
{
    // Zero is electric motorcycle
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("This is the Zerooo refuel tank.");
        }
        public override void Drive()
        {
            Console.WriteLine($"The Midnight {MainColor} Zero zips by you. Vroom Vroooom!");
        }
    }

}