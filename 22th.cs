using System;
class demo
{
	static void Main()
	{	
		xyz obj1=new xyz();
		int val=obj1.assign();
		Console.WriteLine("value of a="+val);
		Console.ReadLine();
	}
}
public class abc
{ 
	protected int a;
}
public class xyz : abc
{
	public int assign()
	{	
		a=10;
		return a;
	}
}