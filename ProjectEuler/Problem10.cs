using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
	static class Problem10
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 9: Special Pythagorean triplet");
			var r = 1d;
			var sw = new Stopwatch();
			sw.Start();


			sw.Stop();
			Console.WriteLine("Time elapsed:	{0}", sw.ElapsedMilliseconds);
			Console.WriteLine("Result:		{0}", r);
			Console.ReadKey();

		}
	}
}
