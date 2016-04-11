using System;
using System.Diagnostics;

namespace Project_Euler
{
	static class Problem5
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 5: Smallest Multiple");
			var r = 1;
			var sw = new Stopwatch();
			sw.Start();

			var numbers = new int[20];
			for(int i = 0; i < 20; i++)
				numbers[i] = i + 1;

			var resolved = false;

			for(int i = 20; !resolved; i += 20)
			{
				resolved = true;
				r = i;
				foreach(int n in numbers)
					resolved &= i % n == 0;
			}

			sw.Stop();
			Console.WriteLine("Time elapsed:	{0}", sw.ElapsedMilliseconds);
			Console.WriteLine("Result:		{0}", r);
			Console.ReadKey();
		}
	}
}
