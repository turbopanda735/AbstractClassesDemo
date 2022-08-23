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
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart = true;
        public override void DriveAbstract()
        {
            var sideCart = "with";
            Console.WriteLine($"This {Year} {Make} {Model} motorcycle {sideCart} a sidecart is driving! This is DriveAbstract from derived class Motorcycle.");
        }
        public override void DriveVirtual()
        {
            var sideCart = "with";
            Console.WriteLine($"This {Year} {Make} {Model} motorcycle {sideCart} a sidecart is driving! This is overriden DriveVirtual from derived class Motorcycle .");
        }
    }
}
