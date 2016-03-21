﻿using System;
using System.Diagnostics;

namespace Project_Euler
{
	static class Problem3
	{
		public static void Run()
		{
			Console.WriteLine("We're just starting out baby. Project Euler - 3");
			double r = 600851475143;
			var sw = new Stopwatch();
			sw.Start();

			for (double i = 5; i < Math.Sqrt(r); i += 2)
			{
				if (isPrime(i))
				{
					while (r % i == 0)
					{
						r /= i;
					}
				}
			}

			sw.Stop();
			Console.WriteLine("Time elapsed:	{0}", sw.ElapsedMilliseconds);
			Console.WriteLine("Result:		{0}", r);
			Console.ReadKey();
		}

		static bool isPrime(double nDbl)
		{
			int n = (int)nDbl;
			if (n <= 1)
				return false;
			else if (n <= 3)
				return true;
			else if (n % 2 == 0 || n % 3 == 0)
				return false;

			// This is from Stack Overflow: http://stackoverflow.com/questions/15414970/fermat-primality-test
			var a = n - 1; ;
			var b = 1;
			for (int i = 0; i < n; i++)
			{
				b *= a;
				b %= n;
			}

			b -= a;

			if (b != 0)
			{
				return false;
			}
			else
			{
				// Just to be sure
				int i = 5;
				int w = 2;
				while (i * i <= n)
				{
					if (n % i == 0)
						return false;

					i += w;
					w = 6 - w;
				}
				return true;
			}
		}
	}
}