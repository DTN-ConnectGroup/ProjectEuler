using System;
using System.Diagnostics;

namespace Project_Euler
{
	static class Problem9
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 9: Special Pythagorean triplet");
			var r = 1d;
			var sw = new Stopwatch();
			sw.Start();

			var limit = 1000;
			for (double a = 1; r == 1 && a < limit; a++)
			{
				for (double b = a; r == 1 && b < limit; b++)
				{
					for (double c = b; r == 1 && c < limit; c++)
					{
						if ((a * a) + (b * b) == (c * c) && a + b + c == 1000)
						{
							r = a * b * c;
						}
					}
				}
			}
			sw.Stop();
			Console.WriteLine("Time elapsed:	{0}", sw.ElapsedMilliseconds);
			Console.WriteLine("Result:		{0}", r);
			Console.ReadKey();

		}
	}
}
