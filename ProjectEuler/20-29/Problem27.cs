using System;

namespace Project_Euler
{
    static class Problem27
    {
        public static double Run()
        {
            Console.WriteLine("Project Euler - 27: Quadratic primes");
            var r = 0d;
            var z = 1d;

            for(int a = -999; a < 1000; a++)
            {
                for(int b = -999; b < 1000; b++)
                {
                    for(int n = 0; ; n++)
                    {
                        if(!isPrime(n * n + a * n + b))
                        {
                            if(n > z)
                            {
                                r = a * b;
                                z = n;
                            }

                            break;
                        }
                    }
                }
            }

            return r;
        }

        static bool isPrime(int n)
        {
            if(n <= 1)
                return false;
            else if(n <= 3)
                return true;
            else if(n % 2 == 0 || n % 3 == 0)
                return false;

            // This is from Stack Overflow: http://stackoverflow.com/questions/15414970/fermat-primality-test
            var a = n - 1;
            var b = 1;
            for(int i = 0; i < n; i++)
            {
                b *= a;
                b %= n;
            }

            b -= a;

            if(b != 0)
                return false;
            else
            {
                // Just to be sure
                int i = 5;
                int w = 2;
                while(i * i <= n)
                {
                    if(n % i == 0)
                        return false;

                    i += w;
                    w = 6 - w;
                }
                return true;
            }
        }
    }
}
