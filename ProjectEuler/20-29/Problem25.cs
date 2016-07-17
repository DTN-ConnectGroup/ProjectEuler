using System;
using System.Numerics;

namespace Project_Euler
{
	static class Problem25
	{
		public static int Run()
		{
			Console.WriteLine("Project Euler - 25: 1000-digit Fibonacci number");

			var pastNumber = new BigInteger(0);
			var currentNumber = new BigInteger(1);

			// Took a lot of trial and error and fidgeting with the numbers.
			for(int i = 0; ; i++)
			{
				var fibonacci = pastNumber + currentNumber;

				if(fibonacci / BigInteger.Pow(10, 999) > 1)
				{
                    return i;
				}

				pastNumber = currentNumber;
				currentNumber = fibonacci;
			}
		}
	}
}
