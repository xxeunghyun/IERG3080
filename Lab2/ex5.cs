
using System;
using System.Collections.Generic;
using System.Linq;


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
			
			int[] allmenu = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //all the menus (selling today + not selling today)
			
			
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

				//check which menu has maximum remaining plate 
				// > to suggest the user when user chosese outofstock lunch or non-serving menu
				KeyValuePair<int, int> sugg = new KeyValuePair<int, int>();
				foreach( KeyValuePair<int, int> kv in lunch)
				{
					if(kv.Value > sugg.Value)
						sugg = kv;
				}
				
				
				//chose proper menu number
				if(lunch.ContainsKey(chose))
				{
					//out of stock
					if(lunch[chose] == 0)
					{
						Console.WriteLine("\nWe do not have lunch {0} now",chose);
						/*Console.WriteLine("====================\nPlease choose other menu");
						Console.WriteLine("Remaining menu below:");
						Console.WriteLine("menu number\tremaining amt");
						
						foreach(int key in lunch.Keys)
			 			 {
							 Console.WriteLine(string.Format("{0}\t\t\t\t{1}",key,lunch[key]));
						  }*/
						
						Console.WriteLine("Would you like to try lunch {0}?",sugg.Key);
					}
				
				
					//has stock
					else
					{					
						
						lunch[chose] -= 1;
						Console.WriteLine("You get a lunch {0}.",chose);
						Console.WriteLine("\n====================");
						Console.WriteLine("Remaining menu below:");
						Console.WriteLine("menu number\tremaining amt");
						
						foreach(int key in lunch.Keys)
			 			 {
							 Console.WriteLine(string.Format("{0}\t\t\t\t{1}",key,lunch[key]));
						  }
						
						List<int> donthave = new List<int>();
						foreach(int key3 in lunch.Keys)
						{
							if(lunch[key3] == 0)
							{
								donthave.Add(key3);	
							}
						}
						
						foreach(int key2 in allmenu)
						{
							if(! lunch.ContainsKey(key2))
							{
								donthave.Add(key2);	
							}
						}
						
						
						Console.WriteLine("Currently we do not have the following lunches: ");
						foreach (var i in donthave)
							{
    							Console.Write (i+"\t");
							}

                                                                             Console.WriteLine();
					
					}
				}
				
				//not available
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


