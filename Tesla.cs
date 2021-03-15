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
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} coolaid Teslas blazes by you. Bzzzzzzzz-oooo!");
        }

    }
}