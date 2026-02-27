//hybried inheritance
using System;
class demo
{
	static void Main()
	{	
		B o1=new B();
		D o2=new D();
		E o3=new E();
		o1.m2();
		o3.m5();
		o2.m3();
		Console.ReadLine();
	}
}
public class A
{
	public void m1()
	{	
		Console.WriteLine("this is display from class A");
	}
}
public class B : A
{
	public void m2()
	{	
		Console.WriteLine("this is show from class B");
		m1();
	}
}
public class D : A
{
	public void m3()
	{	
		Console.WriteLine("this is view from class D");
		m1();
	}
}
public class C : A
{
	public void m4()
	{	
		Console.WriteLine("this is print from class c");
	}
}
public class E : C
{
	public void m5()
	{	
		Console.WriteLine("this is view from class D");
		m1();
		m4();
	}
}