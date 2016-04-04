using System;
using System.Diagnostics;

namespace Project_Euler
{
	static class Problem20
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 20: Factorial digit sum");
			var r = 0;
			var sw = new Stopwatch();
			sw.Start();

			Console.WriteLine("I just used Wolfram alpha for that");

			sw.Stop();
			Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
			Console.WriteLine($"Result:		{r}");
			Console.ReadKey();
		}


	}
}
