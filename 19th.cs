//prectical task
using System;
class demo
{
	static void Main()
	{	
		xyz obj1=new xyz(1,2);
		xyz obj2=new xyz(3,4);
		xyz obj3=new xyz(obj1,obj2);
		Console.ReadLine();
	}
}
public class xyz
{
	int sum=0;
	int x,y;
	public xyz(int a,int b)
	{	
		x=a;y=b;
	}
	public xyz(xyz a,xyz b)
	{	
		sum=a.x+b.x;
		Console.WriteLine("first sum="+sum);
		sum=a.y+b.y;
		Console.WriteLine("second="+sum);
	}
}