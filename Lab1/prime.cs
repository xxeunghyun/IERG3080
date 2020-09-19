

using System;
					
public class Program
{
	static bool isPrime(int x)
	{
		// bool is a boolean type that has value of true/false
		// please implement this method

		int i;

		for (i = 2; i < x; i++)
		{
			if (x % i == 0)
			{
				return false;
			}
		}
		return true;
	}

	public static void Main()
	{
		int x = 11;

		// please implement this program	

		//check whether 11 is prime number or not
		if (isPrime(x) == true)
		{
			Console.WriteLine(x.ToString() + " is prime number");
		}
		else
		{
			Console.WriteLine(x.ToString() + " is not a prime number");
		}

		Console.WriteLine();

		//print out all the prime numbers between 2 and 500
		int i;
		for (i = 2; i <= 500; i++)
		{
			if (isPrime(i) == true)
				Console.WriteLine(i.ToString());
		}
	}
}
