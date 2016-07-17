using System;
using System.Numerics;

namespace Project_Euler
{
    static class Problem26
    {
        public static int Run()
        {
            Console.WriteLine("Project Euler - 26: Reciprocal cycles");
            var r = 0;
            var largest = 0;

            for(int i = 2; i < 1000; i++)
            {
                var ourNum = i;

                while(ourNum % 2 == 0)
                    ourNum /= 2;
                while(ourNum % 5 == 0)
                    ourNum /= 5;

                if(ourNum != 1)
                    for(int j = 1; ; j++)
                        if((BigInteger.Pow(10, j) % ourNum).IsOne)
                        {
                            r = j > largest ? i : r;
                            largest = j > largest ? j : largest;
                            break;
                        }
            }

            return r;
        }
    }
}
