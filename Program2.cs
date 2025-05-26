using System;

class MyClass
{
    public int Number;
}

class Program
{
    static void ModifyValue(int x)
    {
        x = 100;
    }

    static void ModifyReference(MyClass obj)
    {
        obj.Number = 100;
    }

    static void Main()
    {
        int val = 50;
        MyClass refObj = new MyClass { Number = 50 };

        Console.WriteLine($"Before: val = {val}, refObj.Number = {refObj.Number}");

        ModifyValue(val);
        ModifyReference(refObj);

        Console.WriteLine($"After: val = {val}, refObj.Number = {refObj.Number}");
    }
}
