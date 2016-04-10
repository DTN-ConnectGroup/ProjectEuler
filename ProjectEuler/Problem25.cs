using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Project_Euler
{
	static class Problem25
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 25: 1000-digit Fibonacci number");
			var r = 0;
			var sw = new Stopwatch();
			sw.Start();

			var pastNumber = new BigInteger(0);
			var currentNumber = new BigInteger(1);

			// Took a lot of trial and error and fidgeting with the numbers.
			for(int i = 0; ; i++)
			{
				var fibonacci = pastNumber + currentNumber;

				if(fibonacci / BigInteger.Pow(10, 999) > 1)
				{
					r = i;
					break;
				}

				pastNumber = currentNumber;
				currentNumber = fibonacci;
			}


			sw.Stop();
			Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
			Console.WriteLine($"Result:		{r}");
			Console.ReadKey();
		}
	}
}
