/*
needs two random generator -> one for menu items and another for amount of each menu item. Both should be in range between 1 and 10. 
should amount be reduced
*/


using System;
using System.Collections.Generic;


namespace Project
{
	public class Program
	{
		public static void Main(string[] args)
		{
			menu();
		}
		
		//menu items , 5 distinct numbers between 1 and 10
		// each menu - limited amount 1~10
		
		public static void menu()
		{
			Random rand = new Random(0); //random pairs keep the same 
			
			SortedDictionary<int,int> lunch = new SortedDictionary<int,int>(); //generate random numbers in ascending order
			
			int menunum; // = menu number 
			
			for(int i=0;i<5;i++)
			{
				do
				{
					menunum = rand.Next(1,11);
		   
				}while(lunch.ContainsKey(menunum));
				
				
			int amt = rand.Next(1,11); //amount of each menu. 1~10
			
			//add this it dictionary
					   lunch.Add(menunum, amt);
			}
					   
			Console.WriteLine("menu number\tremaining amt");
					   
			
			foreach(int key in lunch.Keys)
			  {
				
				 Console.WriteLine(string.Format("{0}\t\t\t\t{1}",key,lunch[key]));
				
			  }
		
		
			while(true)
			{
				//ask user which menu number he wants
				Console.WriteLine("\nWhich menu do you want to have for lunch?");
				int chose = Convert.ToInt32(Console.ReadLine()); //
				
				if(chose == 0)
				{
					Console.WriteLine("You entered invalid menu option(0). Program ended");
					break;
				}
				
				//chose proper menu number
				else if(lunch.ContainsKey(chose))
				{
					//out of stock
					if(lunch[chose] == 0)
					{
						Console.WriteLine("\nWe do not have lunch {0} now",chose);
						Console.WriteLine("====================");
						Console.WriteLine("Remaining menu below:");
						Console.WriteLine("menu number\tremaining amt");
						
						foreach(int key in lunch.Keys)
			 			 {
							 Console.WriteLine(string.Format("{0}\t\t\t\t{1}",key,lunch[key]));
						  }
					}
				
				
					//has stock
					else
					{					
						
						lunch[chose] -= 1;
						Console.WriteLine("\nYou get a lunch {0}.",chose);
						Console.WriteLine("\n====================");
						Console.WriteLine("Remaining menu below:");
						Console.WriteLine("menu number\tremaining amt");
						
						foreach(int key in lunch.Keys)
			 			 {
							 Console.WriteLine(string.Format("{0}\t\t\t\t{1}",key,lunch[key]));
						  }
					}
				}
				
				
				//not available - but menu number is still not 0
				else
				{
					
					Console.WriteLine("\nWe do not have lunch {0} now",chose);
					Console.WriteLine("\n====================");
					Console.WriteLine("Remaining menu below:");
					Console.WriteLine("menu number\tremaining amt");
						
						foreach(int key in lunch.Keys)
			 			 {
							 Console.WriteLine(string.Format("{0}\t\t\t\t{1}",key,lunch[key]));
						  }
					
					//break;
				}
			}
				
					
		}
	
	}
}			
