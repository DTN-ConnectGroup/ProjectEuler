using System;
using EulerF;

namespace Project_Euler
{
    static class Problem3
    {
        public static double Run ()
        {
            Console.WriteLine ("We're just starting out baby. Project Euler - 3");
            var r = 600851475143d;

            for (var i = 5d; i < Math.Sqrt (r); i += 2)
                if (Helpers.IsPrime ((int) i))
                    while (r % i == 0)
                        r /= i;

            return r;
        }


    }
}
