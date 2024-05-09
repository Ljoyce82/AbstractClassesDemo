using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class MotorCycle : Vehicle
    {
        public bool HasNitrus { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Get this bike slightly used, TODAY!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("We can get this bike New! on another lot.");
        }
    }
}
