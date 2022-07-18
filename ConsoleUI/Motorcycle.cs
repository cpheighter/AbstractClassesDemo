using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This vehicle is a motorcycle");
        }
        public bool HasSideCart { get; set; } = true;
}
}
