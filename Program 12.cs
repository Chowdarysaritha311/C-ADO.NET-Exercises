using System;

class Product
{
    public string Name { get; set; }

    private double price;
    public double Price
    {
        get => price;
        set => price = value >= 0 ? value : 0;
    }
}

class Program
{
    static void Main()
    {
        Product p = new Product { Name = "Laptop", Price = -500 };
        Console.WriteLine($"Name: {p.Name}, Price: {p.Price}");
    }
}
