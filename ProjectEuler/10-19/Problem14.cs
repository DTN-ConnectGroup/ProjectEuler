using System;

namespace Project_Euler
{
    static class Problem14
    {
        public static ulong Run ()
        {
            Console.WriteLine ("Project Euler - 14: Longest Collatz sequence");
            var r = 0ul;

            var t1 = 0ul;
            var t2 = 0ul;
            for (var i = 70ul; i < 1000000; i++)
            {
                t1 = StoppingTime (i);
                if (t1 > t2)
                {
                    t2 = t1;
                    r = i;
                }
            }

            return r;
        }

        static ulong StoppingTime (ulong number)
        {
            var count = 1ul;
            var n = number;
            for (var i = 0ul; n != 1; i++)
            {
                n = n % 2 == 0 ? n / 2 : 3 * n + 1;
                count++;
            }

            return count;
        }
    }
}
