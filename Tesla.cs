using System;
namespace TheVehicles
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public void Drive()
        {
            Console.WriteLine("Bzzzzzzzz!");
        }
    }
}