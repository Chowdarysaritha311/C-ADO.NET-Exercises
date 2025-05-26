public class Contact
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
}

class Program
{
    static void Main()
    {
        Contact? contact = null;
        Console.WriteLine($"Contact Name: {contact?.Name ?? "No contact"}");

        contact = new Contact { Name = null, PhoneNumber = "123456" };
        Console.WriteLine($"Contact Name: {contact?.Name ?? "Name not available"}");

        contact.Name = "John Doe";
        Console.WriteLine($"Contact Name: {contact?.Name}");
    }
}
