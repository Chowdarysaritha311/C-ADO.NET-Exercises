using System;

class CustomClass
{
    public string Description = "Custom class instance";
}

class Program
{
    static void Main()
    {
        var number = 42;
        var text = "Hello";
        var obj = new CustomClass();

        CustomClass anotherObj = new();

        Console.WriteLine($"number: {number}, type: {number.GetType()}");
        Console.WriteLine($"text: {text}, type: {text.GetType()}");
        Console.WriteLine($"obj: {obj.Description}, type: {obj.GetType()}");
        Console.WriteLine($"anotherObj: {anotherObj.Description}, type: {anotherObj.GetType()}");
    }
}
