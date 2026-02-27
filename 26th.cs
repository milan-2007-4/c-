using System;
class demo
{
	static void Main()
	{
		Subchild obj1=new Subchild();
		obj1.getvalue();
		Console.ReadLine();
	}
}
public class perent
{ 
	protected void square(int a)
	{	
		int sq=a*a;
		Console.WriteLine("parent");
		Console.WriteLine("this is display"+sq);
	}
}
public class Child : perent
{
	protected void print(int a)
	{	
		Console.WriteLine("child");
		Console.WriteLine("the value is="+a);
	}
}
public class Subchild : Child
{
	public void getvalue()
	{
		Console.WriteLine("sub child");
		Console.Write("enter number=");
		int val=Convert.ToInt32(Console.ReadLine());
		print(val);
		square(val);
	}
}