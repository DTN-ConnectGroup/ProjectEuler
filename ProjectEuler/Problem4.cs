using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Project_Euler
{
	static class Problem4
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 4");
			var result = 0;
			var sw = new Stopwatch();
			var u = 0;
			sw.Start();


			var threeDigitNums = new List<int>();
			for (int i = 100; i <= 999; i++)
				threeDigitNums.Add(i);

			foreach (int i in threeDigitNums)
			{
				foreach (int j in threeDigitNums)
				{
					u = i * j;
					if (IsPalindrome(u))
					{
						result = u > result ? u : result;
					}

				}
			}


			sw.Stop();
			Console.WriteLine("Time elapsed: {0}ms", sw.ElapsedMilliseconds);
			Console.WriteLine("Solution: {0}", result);
			Console.ReadKey();
		}


		private static bool IsPalindrome(int n)
		{
			var nO = n.ToString();
			var nR = new string(nO.Reverse<char>().ToArray());
			return nO == nR;
		}
	}
}
