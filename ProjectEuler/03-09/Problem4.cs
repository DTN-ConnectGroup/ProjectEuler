using System;
using System.Collections.Generic;
using EulerF;

namespace Project_Euler
{
    static class Problem4
    {
        public static int Run ()
        {
            Console.WriteLine ("Project Euler - 4");
            var r = 0;

            var threeDigitNums = new List<int> ();
            for (var i = 100; i <= 999; i++)
                threeDigitNums.Add (i);

            foreach (var i in threeDigitNums)
                foreach (var j in threeDigitNums)
                    r = (Helpers.IsPalindrome ((i * j).ToString ()) && i * j > r) ? i * j : r;

            return r;
        }
    }
}
