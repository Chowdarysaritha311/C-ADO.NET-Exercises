using System;

class Program
{
    static int CalculateTotal(int a, int b) => a + b;
    static double CalculateTotal(double x, double y, double z) => x + y + z;

    static void Main()
    {
        Console.WriteLine(CalculateTotal(10, 20));
        Console.WriteLine(CalculateTotal(5.5, 2.2, 1.3));
    }
}
