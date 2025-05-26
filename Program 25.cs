using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // FileStream to read file
        using (FileStream fs = new FileStream("sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            string content = Encoding.UTF8.GetString(buffer);
            Console.WriteLine("File Content:");
            Console.WriteLine(content);
        }

        // MemoryStream to write data
        using (MemoryStream ms = new MemoryStream())
        {
            byte[] data = Encoding.UTF8.GetBytes("Hello MemoryStream");
            ms.Write(data, 0, data.Length);
            Console.WriteLine($"Bytes Written: {ms.Length}");
        }
    }
}
