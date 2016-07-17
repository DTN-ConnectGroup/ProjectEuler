using System;
using System.Diagnostics;

namespace Project_Euler
{
    static class Problem14
    {
        public static ulong Run()
        {
            Console.WriteLine("Project Euler - 14: Longest Collatz sequence");
            ulong r = 0;

            ulong t1 = 0;
            ulong t2 = 0;
            for(ulong i = 70; i < 1000000; i++)
            {
                t1 = StoppingTime(i);
                if(t1 > t2)
                {
                    t2 = t1;
                    r = i;
                }
            }

            return r;
        }

		static ulong StoppingTime(ulong number)
		{
			ulong count = 1;
			var n = number;
			for(ulong i = 0; n != 1; i++)
			{
                n = n % 2 == 0 ? n / 2 : 3 * n + 1;
                count++;
			}

            return count;
        }
    }
}
