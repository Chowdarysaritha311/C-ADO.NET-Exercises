using System;

class Program
{
    static void CalculateFactorial(int number)
    {
        int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        Console.WriteLine($"Factorial of {number} is {Factorial(number)}");
    }

    static void Main()
    {
        CalculateFactorial(5);
    }
}
