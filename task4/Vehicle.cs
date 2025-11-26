using System;

namespace VehicleExample
{
    // Abstract class Vehicle
    abstract class Vehicle
    {
        // Abstract methods
        public abstract void StartEngine();
        public abstract void StopEngine();

        // Concrete method
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }

    // Derived class Car
    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }

    // Derived class Bike
    class Bike : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create objects of derived classes
            Car myCar = new Car();
            Bike myBike = new Bike();

            // Call methods
            myCar.Display();
            myCar.StartEngine();
            myCar.StopEngine();

            Console.WriteLine();

            myBike.Display();
            myBike.StartEngine();
            myBike.StopEngine();
        }
    }
}
