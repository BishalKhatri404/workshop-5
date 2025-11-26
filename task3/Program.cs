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

        // ------- Nepali Teacher -------
        NepaliTeacher nt = new NepaliTeacher();
        nt.Name = "Ram";
        Console.WriteLine("Nepali Teacher Name: " + nt.Name);
        nt.Teaching();      // Overridden method
        nt.SalaryInfo();    // Sealed method (cannot be overridden)

        Console.WriteLine();

        // ------- English Teacher -------
        EnglishTeacher et = new EnglishTeacher();
        et.Name = "John";
        Console.WriteLine("English Teacher Name: " + et.Name);
        et.Teaching();      // Inherited from base class
        et.SalaryInfo();    // Inherited sealed method

        Console.ReadLine();
    }
}
