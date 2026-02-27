
using System;

class MainClass
{
    static void Main()
    {
        // Default constructor
        demo obj0 = new demo();

        // Parameter constructors
        demo obj1 = new demo(10);
        demo obj2 = new demo(12.5);
        demo obj3 = new demo("Hello Milan");

        Console.ReadLine();
    }
}

class demo
{
    // Default Constructor
    public demo()
    {
        Console.WriteLine("Default Constructor Called");
    }

    // Integer Constructor
    public demo(int a)
    {
        Console.WriteLine("\nInteger Constructor");
        Console.WriteLine("Value = " + a);
    }

    // Double Constructor
    public demo(double b)
    {
        int val = (int)b;
        Console.WriteLine("\nDouble Constructor");
        Console.WriteLine("Value = " + val);
    }

    // String Constructor
    public demo(string c)
    {
        Console.WriteLine("\nString Constructor");
        Console.WriteLine("Value = " + c);
    }
}