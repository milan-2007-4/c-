//static default perameter constructor task
using System;
class demo
{
	static void Main()
	{	
		xyz obj1=new xyz(5);		
		xyz obj2=new xyz();
		Console.ReadLine();
	}
}
public class xyz
{
	public xyz()
	{	
		Console.WriteLine("default constructor");
	}
	public xyz(int a)
	{	
		Console.WriteLine("value of a="+a);
	}
	static xyz()
	{	
		Console.WriteLine("static constructor");
	}
}