using System;

namespace VehicleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create object of Car
            Car myCar = new Car();
            Console.WriteLine("Car:");
            myCar.Display();
            myCar.StartEngine();
            myCar.StopEngine();

            Console.WriteLine();

            // Create object of Bike
            Bike myBike = new Bike();
            Console.WriteLine("Bike:");
            myBike.Display();
            myBike.StartEngine();
            myBike.StopEngine();
        }
    }
}
