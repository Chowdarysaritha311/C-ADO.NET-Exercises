using System;
using System.IO;
using System.Text.Json;

public class User
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string Email { get; set; } = "";
}

class Program
{
    static void Main()
    {
        var user = new User { Name = "Alice", Age = 30, Email = "alice@example.com" };
        string json = JsonSerializer.Serialize(user);
        File.WriteAllText("user.json", json);

        string jsonFromFile = File.ReadAllText("user.json");
        User deserializedUser = JsonSerializer.Deserialize<User>(jsonFromFile)!;

        Console.WriteLine($"Name: {deserializedUser.Name}, Age: {deserializedUser.Age}, Email: {deserializedUser.Email}");
    }
}
