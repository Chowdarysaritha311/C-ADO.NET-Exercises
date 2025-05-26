using System;

class Program
{
    static void IdentifyObject(object obj)
    {
        // Using is pattern matching
        if (obj is int i)
            Console.WriteLine($"Integer: {i}");
        else if (obj is string s)
            Console.WriteLine($"String: {s}");
        else if (obj is null)
            Console.WriteLine("Object is null");
        else
            Console.WriteLine("Unknown type");

        // Using switch expression
        switch (obj)
        {
            case int n when n > 0:
                Console.WriteLine("Positive integer");
                break;
            case int n when n <= 0:
                Console.WriteLine("Non-positive integer");
                break;
            case string str:
                Console.WriteLine($"String length: {str.Length}");
                break;
            case null:
                Console.WriteLine("Null object");
                break;
            default:
                Console.WriteLine("Other type");
                break;
        }
    }

    static void Main()
    {
        IdentifyObject(5);
        IdentifyObject("hello");
        IdentifyObject(-2);
        IdentifyObject(null);
    }
}
