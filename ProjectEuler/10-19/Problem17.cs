using System;
using System.Diagnostics;
using Humanizer;

namespace Project_Euler
{
	static class Problem17
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 17: Number letter counts");
			var r = 0;
			var sw = new Stopwatch();
			sw.Start();

			for(int i = 1; i <= 1000; i++)
				r += i.ToWords().Dehumanize().Length;

			sw.Stop();
			Console.WriteLine("Time elapsed:	{0}", sw.ElapsedMilliseconds);
			Console.WriteLine("Result:		{0}", r);
			Console.ReadKey();
		}
	}
}
