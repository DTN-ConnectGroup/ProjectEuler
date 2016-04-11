using System;
using System.Diagnostics;
using System.Numerics;

namespace Project_Euler
{
	static class Problem27
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 26: Reciprocal cycles");
			var r = 0;
			var sw = new Stopwatch();
			sw.Start();


			sw.Stop();
			Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
			Console.WriteLine($"Result:		{r}");
			Console.ReadKey();
		}
	}
}
