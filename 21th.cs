//task for get value from user
using System;
class demo
{
	static void Main()
	{	
		xyz obj1=new xyz();		
		obj1.a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("value is="+obj1.a);
		Console.ReadLine();
	}
}
public class xyz
{
	public int a;
}