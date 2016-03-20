using System;
using System.Diagnostics;

namespace Project_Euler
{
	static class Problem6
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 6: Sum of Squares - Square of Sum ( 1 - 100");
			var r = 0;
			var sw = new Stopwatch();
			sw.Start();

			// The sum of squares of the first N natural numbers is
			// (N^3 / 3) + (N^2 / 2) + (N / 6)

			var n = 100;
			var sumOfSquares = (n * (n + 1) * ((2 * n) + 1)) / 6;

			var sum = (1 + n) * (n / 2);

			r = (int)Math.Abs(sumOfSquares - (sum * sum));

			sw.Stop();
			Console.WriteLine("Time elapsed: " + sw.ElapsedMilliseconds);
			Console.WriteLine("The solution is {0}", r);
			Console.ReadKey();
		}
	}
}
