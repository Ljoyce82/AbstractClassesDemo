using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> rides = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            var hella = new Car();
            hella.Make = "Archer";
            hella.Model = "Hella EC-D 1360";
            hella.Year = "2077";
            hella.HasTrunk = true;

            var nazare = new MotorCycle();
            nazare.Make = "Arch";
            nazare.Model = "Nazare";
            nazare.Year = "2077";
            nazare.HasNitrus = true;

            Vehicle mizutani = new Car();
            mizutani.Make = "Arch";
            mizutani.Model = "Mizutani";
            mizutani.Year = "2077";

            Vehicle itsumade = new MotorCycle();
            itsumade.Make = "Arch";
            itsumade.Model = "Itsumade";
            itsumade.Year = "2077";

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            rides.Add(hella);
            rides.Add(nazare);
            rides.Add(mizutani);
            rides.Add( itsumade);

            // Call each of the drive methods for one car and one motorcycle

            foreach(var ride in rides)
            {
                Console.WriteLine($"For Sale: {ride.Make}, {ride.Model}, {ride.Year}");
                ride.DriveVirtual();
                ride.DriveAbstract();
                Console.WriteLine();
            }

            #endregion            
            Console.ReadLine();
        }
    }
}
