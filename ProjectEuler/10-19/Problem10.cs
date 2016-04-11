using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Project_Euler
{
	static class Problem10
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 10: Summation of primes");
			ulong r = 2;
			var sw = new Stopwatch();
			sw.Start();

			var primes = new List<ulong> { 2 };
			bool isPrime = false;

			for(ulong i = 2; i < 2000000; i++)
			{
				isPrime = true;
				foreach(ulong p in primes)
					if(i % p == 0)
					{
						isPrime = false;
						break;
					}

				if(isPrime)
				{
					primes.Add(i);
					r += i;
				}
			}

			sw.Stop();
			Console.WriteLine("Time elapsed:	{0}", sw.ElapsedMilliseconds);
			Console.WriteLine("Result:		{0}", r);
			Console.ReadKey();

		}
	}
}
