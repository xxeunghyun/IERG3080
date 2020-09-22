/*
generates the random number when the user rolls the dice
dice : 1~6

*/

using System;

public class Program
{
	
	
	public static void Main()
	{
		 System.Random ran = new System.Random(); 
		
		Console.WriteLine("The computer rolls the dice and gives you a random number:");
		Console.WriteLine(ran.Next(1, 7)); // random number within the range of 1 ~ 6 ( = 7-1) 
											
   // Next(int min, int max): Returns an int in the range min < = value < maxmin<=value<max
	}
}


