public class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Seats: " + Seats);
    }
}
