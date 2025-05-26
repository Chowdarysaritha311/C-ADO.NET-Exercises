public class Person
{
    public string? Name { get; set; }
}

class Program
{
    static void Main()
    {
        Person? person = null;

        // Safe navigation and null coalescing
        string name = person?.Name ?? "Unknown";

        Console.WriteLine($"Name: {name}");

        person = new Person();
        Console.WriteLine($"Name: {person?.Name ?? "No name provided"}");
    }
}
