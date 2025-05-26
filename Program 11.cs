using System;

class Base
{
    public int PublicVar = 1;
    private int PrivateVar = 2;
    protected int ProtectedVar = 3;

    public void ShowBase()
    {
        Console.WriteLine($"Base: public={PublicVar}, private={PrivateVar}, protected={ProtectedVar}");
    }
}

class Derived : Base
{
    public void ShowDerived()
    {
        Console.WriteLine($"Derived: public={PublicVar}, protected={ProtectedVar}");
        // PrivateVar is not accessible here
    }
}

class Program
{
    static void Main()
    {
        Base b = new Base();
        b.ShowBase();
        Console.WriteLine($"Accessing public from outside: {b.PublicVar}");

        Derived d = new Derived();
        d.ShowDerived();
    }
}
