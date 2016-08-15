using System;
using System.Collections.Generic;
using System.Linq;
using EulerF;

namespace Project_Euler
{
    static class Problem10
    {
        public static ulong Run ()
        {
            Console.WriteLine ("Project Euler - 10: Summation of primes");
            // More efficient than using EulerF.Helpers.PrimeSeq for some reason
            var r = 2ul;
            var primes = new List<ulong> { 2 };

            var isPrime = false;

            for (var i = 2ul; i < 2000000; i++)
            {
                isPrime = true;
                foreach (var p in primes)
                    if (i % p == 0)
                    {
                        isPrime = false;
                        break;
                    }
                if (isPrime)
                {
                    primes.Add (i);
                    r += i;
                }
            }
            return r;
        }
    }
}
