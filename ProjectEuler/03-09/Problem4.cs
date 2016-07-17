using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Project_Euler
{
    static class Problem4
    {
        public static int Run()
        {
            Console.WriteLine("Project Euler - 4");
            var r = 0;
         
            var threeDigitNums = new List<int>();
            for(int i = 100; i <= 999; i++)
                threeDigitNums.Add(i);

            foreach(int i in threeDigitNums)
                foreach(int j in threeDigitNums)
                    r = (IsPalindrome(i * j) && i * j > r) ? i * j : r;

            return r;
        }

        static bool IsPalindrome(int n) => n.ToString() == new string(n.ToString().Reverse<char>().ToArray());

    }
}
