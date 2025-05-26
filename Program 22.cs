using System;

class Program
{
    static (int, string) GetPerson()
    {
        return (25, "John");
    }

    static void Main()
    {
        var (age, name) = GetPerson();
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
