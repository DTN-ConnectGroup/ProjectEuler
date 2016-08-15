using System;

namespace Project_Euler
{
    static class Problem5
    {
        public static int Run ()
        {
            Console.WriteLine ("Project Euler - 5: Smallest Multiple");
            var r = 1;

            var numbers = new int[20];
            for (var i = 0; i < 20; i++)
                numbers[i] = i + 1;

            var resolved = false;

            for (var i = 20; !resolved; i += 20)
            {
                resolved = true;
                r = i;
                foreach (var n in numbers)
                    resolved &= i % n == 0;
            }

            return r;
        }
    }
}
