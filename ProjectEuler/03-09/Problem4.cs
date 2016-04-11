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
			var r = 0;
			var sw = new Stopwatch();
			var u = 0;
			sw.Start();


			var threeDigitNums = new List<int>();
			for(int i = 100; i <= 999; i++)
				threeDigitNums.Add(i);

			foreach(int i in threeDigitNums)
				foreach(int j in threeDigitNums)
				{
					u = i * j;
					if(IsPalindrome(u))
						r = u > r ? u : r;
				}

			sw.Stop();
			Console.WriteLine("Time elapsed:	{0}", sw.ElapsedMilliseconds);
			Console.WriteLine("Result:		{0}", r);
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
