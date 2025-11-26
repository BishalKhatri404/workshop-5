public class Motorcycle : Vehicle
{
    public bool HasCarrier { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Has Carrier: " + (HasCarrier ? "Yes" : "No"));
    }
}
