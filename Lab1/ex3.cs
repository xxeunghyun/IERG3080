/*
done in hard way - better use array method 
*/

using System;

public class Program
{
	public static void Main()
	{
		int[] a = {4,8,6,7,8};
		
		int i,j;
		int tmp;
		int cnt=0;
		int max=0;
		
		Console.WriteLine("Original order: ");
		for(i=0;i<5;i++)
		{	
			Console.Write("{0}  ",a[i]);
		}
		
		Console.WriteLine();
		
		//sorting in ascending order
		for(i=0;i<5;i++)
		{
			for(j=0;j<4;j++)
			{
				if(a[j] > a[j+1])
				{
					tmp = a[j];
					a[j] = a[j+1];
					a[j+1] = tmp;
				}
			}
		}
		
		Console.WriteLine("\nAscending order: ");
		
		//print out the elements in ascending order
		for(i=0;i<5;i++)
		{
			Console.Write("{0}  ",a[i]);
			max = a[4];
		}
		
		Console.WriteLine();
		
		//max number
		Console.WriteLine("\nMaximum number: {0}",max);
		
		for(i=0;i<5;i++)
		{
			if(a[i] == a[4])
				cnt++;
			
		}
		
			Console.WriteLine("\nNumber of times the maximum number occurred : {0}",cnt);
		
		
	}
}
