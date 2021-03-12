using System;

namespace TheVehicles
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public void Turn()
        {
            Console.WriteLine("The vehicle turned right on a red light!!");
        }
        public void Stop()
        {
            Console.WriteLine("But it decided to stop on the next turn and there wasn't even a stop sign nor light. So weird.");
            Console.WriteLine("");
        }
    }
}