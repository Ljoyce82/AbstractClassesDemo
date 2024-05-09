using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2077";

        public string Make { get; set; } = "Archer Quartz";

        public string Model { get; set; } = "Bandit";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine(" We have two of these avaible! ");
        }
    }
}
