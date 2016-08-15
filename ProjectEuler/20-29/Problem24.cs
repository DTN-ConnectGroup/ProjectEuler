using System;
using System.Linq;

namespace Project_Euler
{
    static class Problem24
    {
        public static long Run ()
        {
            Console.WriteLine ("Project Euler - 24: Lexicographic permutations");
            var r = 0L;

            var fstNumber = 0123456789L;
            var lstNumber = 9876543210L;

            var counter = 0;

            // ugly bruteforce.

            for (var i = fstNumber; i < lstNumber; i++)
            {
                var s = i.ToString ();
                var ContainsTheNums = (s.Contains ('0') || s.Length == 9)
                        && s.Contains ('1')
                        && s.Contains ('2')
                        && s.Contains ('3')
                        && s.Contains ('4')
                        && s.Contains ('5')
                        && s.Contains ('6')
                        && s.Contains ('7')
                        && s.Contains ('8')
                        && s.Contains ('9');

                if (ContainsTheNums)
                {
                    counter++;
                    Console.WriteLine (i);
                    r = i;
                }

                if (counter == 1000000)
                    break;
            }

            return r;
        }
    }
}
