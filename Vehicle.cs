using System;

namespace TheVehicles
{
    // Vehicle will be our parent/base class. And the name Vehicle is good bc all of the child classes are car
    // And the two properties we define here, in this class can be used in
    // the sub/child classes
    public class Vehicle
    {
        //Properties
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public virtual void Drive() //we will define a Drive() method here so the child classes can use this if they want to
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn() //Turn() method also the child classes can use
        {
            Console.WriteLine("The vehicle turned right on a red light!!");
        }
        public virtual void Stop() // And Stop() method
        {
            Console.WriteLine("But it decided to stop on the next turn and there wasn't even a stop sign nor light. So weird.");
            Console.WriteLine("");
        }
    }
}