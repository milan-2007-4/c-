using System;
class sum_sub
{
    static void Main()
    {
        int x=20;
        int y=5;

        com_sub_sum obj=new com_sub_sum();
        obj.Calculate( x, ref y);
    }
}

class com_sub_sum
{
    public void Calculate(ref int a, ref int b)
    {
        int sum=a+b;
        int sub=a-b;
        Console.WriteLine("Sum="+sum);
        Console.WriteLine("Subtraction="+sub);
    }
}


