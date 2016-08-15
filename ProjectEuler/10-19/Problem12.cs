using System;
using EulerF;

namespace Project_Euler
{
    static class Problem12
    {
        public static double Run ()
        {
            Console.WriteLine ("Project Euler - 12: Highly divisible triangular number");
            var r = 0;

            var isFive = false;

            for (var i = 1; !isFive; i++)
            {
                r += i;
                isFive = Helpers.DivisorCount (r) > 500;
            }

            return r;
        }
    }
}
