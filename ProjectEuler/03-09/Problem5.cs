using System;
using System.Diagnostics;

namespace Project_Euler
{
    static class Problem5
    {
        public static int Run()
        {
            Console.WriteLine("Project Euler - 5: Smallest Multiple");
            var r = 1;

            var numbers = new int[20];
            for(int i = 0; i < 20; i++)
                numbers[i] = i + 1;

            var resolved = false;

            for(int i = 20; !resolved; i += 20)
            {
                resolved = true;
                r = i;
                foreach(int n in numbers)
                    resolved &= i % n == 0;
            }

            return r;
        }
    }
}
