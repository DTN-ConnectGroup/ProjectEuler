using System;

namespace Project_Euler
{
    static class Problem23
    {
        public static double Run()
        {
            Console.WriteLine("Project Euler - 23: Non-abundant sums");
            var r = 0d;

            for(double i = 1; i <= 28123; i++)
            {
                if(!IsSumOfTwoAbundant(i))
                {
                    r += i;
                }
            }

            return r;
        }

        static double DivisorSum(double x)
        {
            var val = 1d;
            for(double i = 2; i * i <= x; i++)
                val += x % i == 0 ? (i == x / i ? i : i + x / i) : 0; // voodoo

            return val;
        }

        static bool IsAbundant(double x) => x < DivisorSum(x);

        static bool IsSumOfTwoAbundant(double x)
        {
            for(double i = 1; i < x; i++)
                if(IsAbundant(i) && IsAbundant(x - i))
                    return true;

            return false;
        }
    }
}