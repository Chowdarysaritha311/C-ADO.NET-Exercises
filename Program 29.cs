using System;
using System.Net;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your comment:");
        string input = Console.ReadLine() ?? "";

        // Sanitize input using HTML encoding
        string safeInput = WebUtility.HtmlEncode(input);

        Console.WriteLine("Sanitized output:");
        Console.WriteLine(safeInput);
    }
}
