using System;
using System.Threading;
namespace FactoryPattern
{
    public class ConsoleLogger
    {
        public static void VehicleStartUpDialogue()
        {
            Console.WriteLine("Put Key ignition");
            Thread.Sleep(1000);
            Console.WriteLine("Turn Key!");
            Thread.Sleep(1000);
        }
    }
}
