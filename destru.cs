using System;
class destru				
{
	static void Main()
	{
		xyz obj1=new xyz();
		xyz obj2=new xyz();
		Console.ReadLine();
		Console.WriteLine("hello");
	}
}
public class xyz
{
	public xyz()
	{
		Console.WriteLine("hii");
	}
	~xyz()
	{
		Console.WriteLine("destructor");
	}
}