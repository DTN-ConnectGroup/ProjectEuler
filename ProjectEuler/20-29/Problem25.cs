using System;
using System.Numerics;
using EulerF;

namespace Project_Euler
{
    static class Problem25
    {
        public static int Run ()
        {
            Console.WriteLine ("Project Euler - 25: 1000-digit Fibonacci number");

            var bigConstant = BigInteger.Pow (10, 999);

            for (int i = 0; ; i++)
                if (Helpers.FibonacciBigInt (i) / bigConstant > 1)
                    return i;
        }
    }
}
