/*Continued from Problem 1, write a static method RemoveMultipleOfThree 
that removes all numbers that are multiple of threes from the list. */




 // multiple of threes > n%3 == 0 > remove

public static void RemoveMultipleOfThree(List<int> list)
		{
			for(int i=0;i<list.Count;i++)
			{
				if(list[i] % 3 == 0)
				{
					list.RemoveAt(i);
					i--;

				}
				
			}
		}
