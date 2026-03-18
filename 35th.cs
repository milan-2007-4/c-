using System;
class demo
{
    public delegate int sumdel(int a,int b);
    public static int sum(int x,int y)
    {
        return x+y;
    }
}
class program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b=Convert.ToInt32(Console.ReadLine());
        demo.sumdel d=demo.sum;
        int r=d(a,b);
        Console.WriteLine("Sum="+r);
    }
}
