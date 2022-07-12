using System;

namespace FactoryPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int wheeCount;
            bool input;
            {
                Console.WriteLine("Enter the amount of tries for the vehicl you want to create:");

                input = int.TryParse(Console.ReadLine(), out wheeCount);

            }while (input == false);
            _ = VehicleFactory.GetVehicle(wheeCount);

        }
    }
}
