public class Student
{
    public required string Name { get; init; }
    public required int Age { get; init; }
}

class Program
{
    static void Main()
    {
        // Compilation error if required properties are not initialized
        Student s = new Student { Name = "Emma", Age = 20 };

        Console.WriteLine($"Name: {s.Name}, Age: {s.Age}");
    }
}
