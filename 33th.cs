using System;
class Person
{
    private string name;
    public string Name
    {
        get { return name; }      
        set { name = value; }    
    }
}


class Program
{
    static void Main()
    {
        Person p = new Person();
        Console.Write("Enter name: ");
        string input = Console.ReadLine();

        // set value using property
        p.Name = input;

        // get and print value
        Console.WriteLine("Name is: " + p.Name);
    }
}
