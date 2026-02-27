using System;
class taskfortwoD
{
	public static void Main()
	{
		child o1=new child();
		o1.assign();
		for(int i=0;i<o1.a.Length;i++)
		{
			for(int j=0;j<o1.a[i].Length;j++)
			{
				o1.a[i][j]=1;	
				if((i==0 && j==0)||(i==3 && j==0))
					o1.a[i][j]=0;
			}
		}
		o1.pirnt();
	}
}
public class parent
{
	public int [][]a=new int[5][];
	public void assign()
	{
	a[0]=new int[5];
	a[1]=new int[1];
	a[2]=new int[3];
	a[3]=new int[1];
	a[4]=new int[5];
	}
}
public class child : parent
{
	public void pirnt()
	{
		for(int i=0;i<a.Length;i++)
		{
			for(int j=0;j<a[i].Length;j++)
			{
				Console.Write(a[i][j]+" ");
			}
			Console.WriteLine();
		}
	}
}