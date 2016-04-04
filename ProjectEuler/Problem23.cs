using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Project_Euler
{
	static class Problem23
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 23: Non-abundant sums");
			double r = 0;
			var sw = new Stopwatch();
			sw.Start();


			for(double i = 1; i <= 28123; i++)
				if(!IsSumOfTwoAbundant(i))
					r += i;

			sw.Stop();
			Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
			Console.WriteLine($"Result:		{r}");
			Console.ReadKey();
		}

		static double DivisorSum(double x)
		{
			var val = 1d;
			for(double i = 2; i * i <= x; i++)
				val += x % i == 0 ? (i == x / i ? i : i + x / i) : 0; // voodoo

			return val;
		}

		static bool IsAbundant(double x) => x < DivisorSum(x);

		static bool IsSumOfTwoAbundant(double x)
		{
			for(double i = 1; i < x; i++)
				if(IsAbundant(i) && IsAbundant(x - i))
					return true;

			return false;
		}
	}
}