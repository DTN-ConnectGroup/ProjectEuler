using System;
using System.Diagnostics;

namespace Project_Euler
{
	static class Problem28
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 28: Number spiral diagonals");
			var r = 0d;
			var sw = new Stopwatch();
			sw.Start();



			sw.Stop();
			Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
			Console.WriteLine($"Result:		{r}");
			Console.ReadKey();
		}
	}
}
