public class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public void Start()
    {
        Console.WriteLine(Brand + " is starting...");
    }

    public void Stop()
    {
        Console.WriteLine(Brand + " is stopping...");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Speed: " + Speed + " km/h");
    }
}
