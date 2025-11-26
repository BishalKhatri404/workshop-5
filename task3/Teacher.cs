public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    public sealed void SalaryInfo()
    {
        Console.WriteLine("Teacher salary is confidential.");
    }
}

public class NepaliTeacher : Teacher
{
    public override void Teaching()
    {
        Console.WriteLine("Nepali Teacher teaches in Nepali language.");
    }
}

public class EnglishTeacher : Teacher
{
    // Does not override teaching() → uses base version
}
