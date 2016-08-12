using System;
using System.Collections.Generic;
using EulerF;

namespace Project_Euler
{
    static class Problem37
    {
        public static long Run()
        {
            Console.WriteLine("Project Euler - 37: Truncatable primes");

            var r = 0;
            var count = 0;
            for(var i = 9; count < 11; i += 2)
            {
                if(IsTruncatablePrime(i))
                {
                    r += i;
                    count++;
                }
            }
            return r;
        }

        static IEnumerable<int> Truncate(int n)
        {
            var length = n.ToString().Length;
            yield return n;

            for(int i = 1; i < length; i++)
            {
                var tenPower = (int)Math.Pow(10, i);
                yield return n / tenPower;
                yield return n % tenPower;
            }
        }

        static bool IsTruncatablePrime(int n)
        {
            if(n % 2 == 0 || n % 10 == 5 || n % 10 == 9 || n % 10 == 1 || (n % 100) % 3 == 0 || (n % 1000) % 3 == 0 || (n % 10000) % 3 == 0)
                return false;

            var s = n.ToString();
            // The Reason I couldnt find a solution earlier was because I added "2" and "5" to this iist, which excludes the very valid numbers 23 and 53
            if(s.Contains("0") || s.Contains("4") || s.Contains("6") || s.Contains("8"))
                return false;

            foreach(var i in Truncate(n))
            {
                if(!Helpers.IsPrime(i))
                    return false;
            }

            return true;
        }
    }
}