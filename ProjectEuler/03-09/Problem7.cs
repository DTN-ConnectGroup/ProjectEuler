using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Project_Euler
{
    static class Problem7
    {
        public static long Run()
        {
            Console.WriteLine("Project Euler - 7: 10001st prime");
            var primes = new List<long> { 2 };
            var isPrime = false;

            for(int i = 2; primes.Count < 10001; i++)
            {
                isPrime = true;
                foreach(long p in primes)
                    if(i % p == 0)
                    {
                        isPrime = false;
                        break;
                    }

                if(isPrime)
                    primes.Add(i);
            }

            return primes.Last();
        }
    }
}
