//hirarchical inheritance
using System;
class demo
{
	static void Main()
	{	
		B o1=new B();
		C o2=new C();
		D o3=new D();		
		o1.show();
		o2.print();
		o3.view();
		Console.ReadLine();
	}
}
public class A
{
	public void disp()
	{	
		Console.WriteLine("this is display from class A");
	}
}
public class B : A
{
	public void show()
	{	
		Console.WriteLine("this is show from class B");
		disp();
	}
}
public class C : A
{
	public void print()
	{	
		Console.WriteLine("this is print from class c");
		disp();
	}
}
public class D : A
{
	public void view()
	{	
		Console.WriteLine("this is view from class D");
		disp();
	}
}