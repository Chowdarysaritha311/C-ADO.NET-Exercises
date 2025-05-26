using System;

class Car
{
    public string Make;
    public string Model;
    public int Year;

    public Car()
    {
        Make = "DefaultMake";
        Model = "DefaultModel";
        Year = 2000;
    }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void Display()
    {
        Console.WriteLine($"{Make} {Model} ({Year})");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        Car car2 = new Car("Toyota", "Corolla", 2022);

        car1.Display();
        car2.Display();
    }
}
