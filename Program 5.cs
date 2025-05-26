using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your score: ");
        int score = int.Parse(Console.ReadLine());

        // if-else
        if (score >= 90) Console.WriteLine("Grade: A");
        else if (score >= 80) Console.WriteLine("Grade: B");
        else if (score >= 70) Console.WriteLine("Grade: C");
        else if (score >= 60) Console.WriteLine("Grade: D");
        else Console.WriteLine("Grade: F");

        // switch with pattern matching
        switch (score)
        {
            case >= 90: Console.WriteLine("Grade via switch: A"); break;
            case >= 80: Console.WriteLine("Grade via switch: B"); break;
            case >= 70: Console.WriteLine("Grade via switch: C"); break;
            case >= 60: Console.WriteLine("Grade via switch: D"); break;
            default: Console.WriteLine("Grade via switch: F"); break;
        }
    }
}
