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
        public void Drive()
        {
            Console.WriteLine("Vroom Vroooom!");
        }
    }

}