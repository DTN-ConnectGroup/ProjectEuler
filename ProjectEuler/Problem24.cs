using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
	static class Problem24
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 24: Lexicographic permutations");
			var r = 0L;
			var sw = new Stopwatch();
			sw.Start();

			var fstNumber = 0123456789;
			var lstNumber = 9876543210;

			var counter = 0;

			// ugly bruteforce.

			for(long i = fstNumber; i < lstNumber; i++)
			{
				var s = i.ToString();
				var ContainsTheNums = (s.Contains('0') || s.Length == 9)
						&& s.Contains('1')
						&& s.Contains('2')
						&& s.Contains('3')
						&& s.Contains('4')
						&& s.Contains('5')
						&& s.Contains('6')
						&& s.Contains('7')
						&& s.Contains('8')
						&& s.Contains('9');

				if(ContainsTheNums)
				{
					counter++;
					Console.WriteLine(i); 
					r = i;
				}

				if(counter == 1000000)
					break;
			}

			sw.Stop();
			Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
			Console.WriteLine($"Result:		{r}");
			Console.ReadKey();
		}
	}
}
