using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Text;

namespace ConsoleUI
{
            /* Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */
    abstract class Vehicle
    {
        public int Year { get; set; }
        public string Make {get; set;}
        public string Model { get; set;}
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"The {Year} {Make} {Model} is driving! This is DriveVirtual from base class Vehicle.");
        }
    }
}
