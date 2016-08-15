using System;
using EulerF;

namespace Project_Euler
{
    static class Problem27
    {
        public static double Run ()
        {
            Console.WriteLine ("Project Euler - 27: Quadratic primes");
            var r = 0d;
            var z = 1d;

            for (var a = -999; a < 1000; a++)
                for (var b = -999; b < 1000; b++)
                    for (var n = 0; ; n++)
                        if (!Helpers.IsPrime (n * n + a * n + b))
                        {
                            if (n > z)
                            {
                                r = a * b;
                                z = n;
                            }

                            break;
                        }

            return r;
        }


    }
}
