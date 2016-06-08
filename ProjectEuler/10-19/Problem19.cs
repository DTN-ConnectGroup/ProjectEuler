using System;
using System.Diagnostics;

namespace Project_Euler
{
	static class Problem19
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 19: Counting Sundays");
			var r = 0;
			var sw = new Stopwatch();
			sw.Start();

			var fstDay = new DateTime(1901, 1, 1);
			var lstDay = new DateTime(2000, 12, 31);

			var tempDay = fstDay;

			for(int i = 0; tempDay <= lstDay; i++)
				if(fstDay.AddDays(i).Day == 1 && tempDay.DayOfWeek == DayOfWeek.Sunday)
					r++;

			sw.Stop();
			Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
			Console.WriteLine($"Result:		{r}");
			Console.ReadKey();
		}
	}
}
