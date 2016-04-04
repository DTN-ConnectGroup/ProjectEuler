using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

			DateTime tempDay = fstDay;

			for(int i = 0; tempDay <= lstDay; i++)
			{
				tempDay = fstDay.AddDays(i);
				if(tempDay.Day == 1 && tempDay.DayOfWeek == DayOfWeek.Sunday)
					r++;
			}

			sw.Stop();
			Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
			Console.WriteLine($"Result:		{r}");
			Console.ReadKey();
		}
	}
}
