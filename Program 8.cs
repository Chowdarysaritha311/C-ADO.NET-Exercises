using System;

class Program
{
    static void AddRef(ref int x) { x += 10; }
    static void GetOut(out int y) { y = 100; }
    static void ShowIn(in int z) { Console.WriteLine($"in: {z}"); }

    static void Main()
    {
        int a = 5, b;
        Console.WriteLine($"Before ref: {a}");
        AddRef(ref a);
        Console.WriteLine($"After ref: {a}");

        GetOut(out b);
        Console.WriteLine($"After out: {b}");

        ShowIn(in a);
    }
}
