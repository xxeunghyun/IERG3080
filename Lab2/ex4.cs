
using System;
using System.Collections.Generic;
  
  
public class Program1
{
	public static void Main()
		{
			List<int> list = new List<int>();
  
			Console.WriteLine("Please input integers: (in one line)");
  
  

			string input = Console.ReadLine();
			string[] tokens = input.Split(); // split string into tokens "12 13 10" -> "12" "13" "10"


			foreach (string s in tokens) {

				int num; 
			  //	bool success = int.TryParse(s,out num); // TryParse returns true if successfully converted s into an int
                 									    // the converted int is put into the second parameter using keyword "out"  
         											    // do you know why "out" is used here? why not return the converted integer?
          /* if (success) {
               list.Add(num); // add num to list if success
           }
				*/
			   try 
			   {
				   num = int.Parse(s);
				   list.Add(num);
			    }

			   catch (Exception e)
				   {
					   Console.WriteLine("Error occurred! ",e.Message);
				   		break;
				   }


			}

			Console.WriteLine("Sorted input:");
			list.Sort();
			foreach(int i in list) {
				Console.WriteLine(i);
			}
			Console.WriteLine("Sorted input in reverse:");
			for (int i=list.Count-1;i>=0;i--) {
				Console.WriteLine(list[i]);
			}

			}
		}



