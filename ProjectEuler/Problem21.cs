using System;
using System.Diagnostics;

namespace Project_Euler
{
	static class Problem21
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 21 Amicable numbers");
			var r = 0;
			var sw = new Stopwatch();
			sw.Start();

			for(int i = 1; i < 10000; i++)
			{
				if(IsAmicable(i))
					r += i;
			}

			sw.Stop();
			Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
			Console.WriteLine($"Result:		{r}");
			Console.ReadKey();
		}

		static double DivisorSum(double x)
		{
			var val = 0d;
			for(int i = 1; i * i <= x; i++)
			{
				if(x % i == 0)
				{
					val += i;
					val += x / i == i ? 0 : x / i;
					// Original version of this line was "val += x / i;"
					// which caused a bug that affected Problem 23
					//
					// This is the arithmatically correct version.
					// Rewritten into an ugly oneliner in Problem 23.
				}
			}
			return val - x;
		}

		static bool IsAmicable(double x)
		{
			var y = DivisorSum(x);
			return (x == DivisorSum(y) && x!= y);
		}
	}
}
