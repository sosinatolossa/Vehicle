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
            Console.WriteLine("The coolaid Teslas blazes by you. Bzzzzzzzz-oooo!");
        }

    }
}