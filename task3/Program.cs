using System;

class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer();

        // Call Print(string)
        p.Print("Hello World");

        // Call Print(int)
        p.Print(123);

        // Call Print(string, int)
        p.Print("Repeat Message", 3);

        Console.ReadLine();
    }
}
