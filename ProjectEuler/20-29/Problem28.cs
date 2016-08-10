using System;

namespace Project_Euler
{
    static class Problem28
    {
        public static double Run()
        {
            Console.WriteLine("Project Euler - 28: Number spiral diagonals");
            var acc = 1;

            for(int i = 1001; i > 1; i -= 2)
            {
                var sqn = i * i;
                acc += sqn + (sqn - i + 1) + (sqn - 2 * i + 2) + (sqn - 3 * i + 3);
            }

            return acc;
        }
    }
}
