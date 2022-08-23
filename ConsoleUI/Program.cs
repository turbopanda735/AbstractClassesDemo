using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /* 
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /*
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehicleList = new List<Vehicle>();

            /*
            * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
            * - new it up as one of each derived class
            * Set the properties with object initializer syntax
            */

            var car = new Car()
            {
                Year = 1990,
                Make = "Toyota",
                Model = "Corolla",
            };
            var bike = new Motorcycle()
            {
                Year = 2023,
                Make = "Honda",
                Model = "Speed Bike",
            };
            Vehicle car2 = new Car()
            {
                Year = 2020,
                Make = "Nissan",
                Model = "Altima",
            };
            Vehicle bike2 = new Motorcycle()
            {
                Year = 2003,
                Make = "Honda",
                Model = "Slow Bike",
            };

            /*
            * Add the 4 vehicles to the list
            * Using a foreach loop iterate over each of the properties
            */

            vehicleList.Add(bike);
            vehicleList.Add(car);
            vehicleList.Add(bike2);
            vehicleList.Add(car2);

            foreach (var automobile in vehicleList)
            {
                Console.WriteLine($"Year: {automobile.Year}");
                Console.WriteLine($"Make: {automobile.Make}");
                Console.WriteLine($"Model: {automobile.Model}");
            }

            // Call each of the drive methods for one car and one motorcycle

            bike.DriveAbstract();
            bike.DriveVirtual();

            bike2.DriveAbstract();
            bike2.DriveVirtual();

            car.DriveAbstract();
            car.DriveVirtual();

            car2.DriveAbstract();
            car2.DriveVirtual();

            #endregion
            Console.ReadLine();
        }
    }
}
