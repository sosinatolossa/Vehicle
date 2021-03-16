using System;
namespace TheVehicles
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("This is the tesla refuel tank.");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} coolaid Teslas blazes by you. Bzzzzzzzz-oooo!");
        }

    }
}