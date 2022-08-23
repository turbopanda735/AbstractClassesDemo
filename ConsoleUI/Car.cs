using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    /* 
    * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
    * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
    * Provide the implementations for the abstract methods
    * Only in the Motorcycle class will you override the virtual drive method
    */
    internal class Car : Vehicle
    {
        public bool HasTrunk = true;
        public override void DriveAbstract()
        {
            var trunk = "with";
            Console.WriteLine($"This {Year} {Make} {Model} car {trunk} a trunk is driving! This is DriveAbstract from derived class Car.");
        }
    }
}
