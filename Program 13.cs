public record Employee
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Department { get; init; }
}

class Program
{
    static void Main()
    {
        var emp1 = new Employee { Id = 1, Name = "Alice", Department = "HR" };
        var emp2 = emp1 with { Department = "Finance" };

        Console.WriteLine($"Original: {emp1.Name}, Dept: {emp1.Department}");
        Console.WriteLine($"Modified: {emp2.Name}, Dept: {emp2.Department}");
    }
}
