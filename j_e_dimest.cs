using System;
class j_e_dimest 
{   public static void Main()
	{
		chiled ol=new chiled();
		ol.geting();
		ol.j_arrey[0][0]=1;
		ol.j_arrey[0][1]=1;
		ol.j_arrey[0][2]=1;
		ol.j_arrey[0][3]=1;
		ol.j_arrey[0][4]=1;
		
		
		ol.j_arrey[1][0]=1;
		
		ol.j_arrey[2][0]=1;
		ol.j_arrey[2][1]=1;
		ol.j_arrey[2][2]=1;
		
		ol.j_arrey[3][0]=1;
		
		ol.j_arrey[4][0]=1;
		ol.j_arrey[4][1]=1;
		ol.j_arrey[4][2]=1;
		ol.j_arrey[4][3]=1;
		ol.j_arrey[4][4]=1;
		
		 /*   for(int a=0;a<j_arrey.Length;a++)
		{
			for(int v=0;v<j_arrey[a].Length;v++)
			{    Console.ForegroundColor = ConsoleColor.Magenta;
				ol.a[a][v]=1;
				if(a==0 && v==0|| a==3 && v==0)
			}
			Console.WriteLine();
		}*/
	
	
		chiled ol=new chiled();
		ol.geting();
		Console.Write("Enter number of rows=");
        int r = Convert.ToInt32(Console.ReadLine());
        int[][] j_array = new int[r][];
		Console.ForegroundColor=ConsoleColor.Green;
        for (int i = 0; i < r; i++)
        {
            Console.Write("enter number of columns for row " + i + ": ");
            int c = Convert.ToInt32(Console.ReadLine());
            j_array[i] = new int[c];
            for (int j = 0; j < c; j++)
            {
                Console.Write("enter value for [" + i + "][" + j + "]: ");
                j_array[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
		
		
		
		ol.print();
	}
	
}
public class parent
{
	public int [][] j_arrey=new int[5][];
	public void geting()
	{
		j_arrey[0]=new int[5];
		j_arrey[1]=new int[1];
		j_arrey[2]=new int[3];
		j_arrey[3]=new int[1];
		j_arrey[4]=new int[5];
	}
}

 public class chiled : parent
{    	
	public void print()
	{
		
		for(int a=0;a<j_arrey.Length;a++)
		{
			for(int v=0;v<j_arrey[a].Length;v++)
			{
				Console.Write(j_arrey[a][v]+"  ");
			}
			Console.WriteLine();
		}
		
		
	}
		
		
}
