﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
	static class Problem7
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 7: 10001st prime");
			var r = 0L;
			var sw = new Stopwatch();
			sw.Start();

			var primes = new List<long> { 2 };
			bool isPrime = false;


			for (int i = 2; primes.Count < 10001; i++)
			{
				isPrime = true;
				foreach (long p in primes)
				{
					if (i % p == 0)
					{
						isPrime = false;
						break;
					}
				}

				if (isPrime)
				{
					primes.Add(i);
				}
			}

			r = primes.Last();
			sw.Stop();
			Console.WriteLine("Time elapsed: " + sw.ElapsedMilliseconds);
			Console.WriteLine("The solution is {0}", r);
			Console.ReadKey();
		}
	}
}