using System;

namespace Project_Euler
{
    static class Problem6
    {
        public static int Run ()
        {
            Console.WriteLine ("Project Euler - 6: Sum of Squares - Square of Sum ( 1 - 100");

            // The sum of squares of the first N natural numbers is
            // (N^3 / 3) + (N^2 / 2) + (N / 6)

            var n = 100;
            var sumOfSquares = (n * (n + 1) * ((2 * n) + 1)) / 6;

            var sum = (1 + n) * (n / 2);

            return Math.Abs (sumOfSquares - (sum * sum));
        }
    }
}
