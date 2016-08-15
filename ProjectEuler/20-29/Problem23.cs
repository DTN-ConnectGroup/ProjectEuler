using System;
using EulerF;

namespace Project_Euler
{
    static class Problem23
    {
        public static double Run ()
        {
            Console.WriteLine ("Project Euler - 23: Non-abundant sums");
            var r = 0d;

            for (var i = 1; i <= 28123; i++)
                if (!IsSumOfTwoAbundant (i))
                    r += i;

            return r;
        }

        static bool IsAbundant (double x) => x < Helpers.DivisorSum (x);

        static bool IsSumOfTwoAbundant (double x)
        {
            for (var i = 1; i < x; i++)
                if (IsAbundant (i) && IsAbundant (x - i))
                    return true;

            return false;
        }
    }
}