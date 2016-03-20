using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			for (int i = 0; i < 20; i++)
				numbers[i] = i + 1;
			

			var resolved = false;

			for (int i = 20; !resolved; i+= 20)
			{
				resolved = true;
				r = i;
				foreach (int n in numbers)
				{
					resolved &= i % n == 0;
				}
			}

			sw.Stop();
			Console.WriteLine("Time elapsed: " + sw.ElapsedMilliseconds);
			Console.WriteLine("The solution is {0}", r);
			Console.ReadKey();
		}
	}
}
