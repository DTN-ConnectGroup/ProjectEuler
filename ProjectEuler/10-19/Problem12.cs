using System;
using System.Diagnostics;

namespace Project_Euler
{
    static class Problem12
    {
        public static double Run()
        {
            Console.WriteLine("Project Euler - 12: Highly divisible triangular number");
            double r = 0;

            bool isFive = false;

            for(int i = 1; !isFive; i++)
            {
                r += i;
                isFive = DivisorCount(r) > 500;
            }

            return r;

        }

        static int DivisorCount(double x)
        {
            var val = 0;
            for(int i = 1; i * i <= x; i++)
                if(x % i == 0)
                    val += 2;
            return val;
        }
    }
}
