using System;
class demo
{
	static void Main()
	{	
		Child obj1=new Child();
		Subchild obj2=new Subchild();
		obj1.child();
		obj2.subchild();
		Console.ReadLine();
	}
}
public class perent
{ 
	protected void disp()
	{	
		Console.WriteLine("this is display");
	}
}
public class Child : perent
{
	public void child()
	{	
		disp();
	}
}
public class Subchild : Child
{
	public void subchild()
	{
		disp();
	}
}