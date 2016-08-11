using System;
using EulerF;

namespace Project_Euler
{
    static class Problem21
    {
        public static int Run()
        {
            Console.WriteLine("Project Euler - 21 Amicable numbers");
            var r = 0;

            for(int i = 1; i < 10000; i++)
                if(IsAmicable(i))
                    r += i;

            return r;
        }

        static bool IsAmicable(double x)
        {
            var y = Helpers.DivisorSum(x);
            return (x == Helpers.DivisorSum(y) && x != y);
        }
    }
}
