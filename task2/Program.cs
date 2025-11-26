using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Car Object ---
        Car car = new Car();
        car.Brand = "Toyota";
        car.Speed = 180;
        car.Seats = 5;

        Console.WriteLine("---- Car Info ----");
        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        // --- Motorcycle Object ---
        Motorcycle moto = new Motorcycle();
        moto.Brand = "Yamaha";
        moto.Speed = 120;
        moto.HasCarrier = true;

        Console.WriteLine("---- Motorcycle Info ----");
        moto.Start();
        moto.DisplayInfo();
        moto.Stop();

        Console.ReadLine();
    }
}
