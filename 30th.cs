using System;
class demo 
{
	static void Main()
	{
		pqr p=new pqr();
		xyz x=new xyz();
		p.method();
		x.method1();
		x.method();
		Console.ReadLine();
	}
}
public class abc 
{
	public virtual void method()
	{
		Console.WriteLine("hi abc");
	}
}
public class pqr : abc 
{
	public sealed override void method()
	{
		Console.WriteLine("hello pqr");
	}
}
public class xyz : pqr
{
	public void method1()
	{
		Console.WriteLine("hello xyz");
		//method();
	}
}
