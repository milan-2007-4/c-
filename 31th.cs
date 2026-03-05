using System;
class squer_qub
{
     public static void Main()
    {    int squer,cube;
		com_sub_sum ob=new com_sub_sum();
		ob.Calculate(out squer,out cube);
		Console.WriteLine("sueqr"+squer);
        Console.WriteLine("queb="+cube);
		
        
    }
}

class com_sub_sum
{
    public void Calculate(out int sq, out int cb)
    {    int a,b; 
	    Console.WriteLine("enter velue of a=");
	    a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter velue of b=");
	    b=Convert.ToInt32(Console.ReadLine());
         sq=a*a;
		 cb=b*b*b;
        
    }
}


