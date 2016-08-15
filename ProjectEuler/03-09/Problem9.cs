using System;

namespace Project_Euler
{
    static class Problem9
    {
        public static int Run ()
        {
            Console.WriteLine ("Project Euler - 9: Special Pythagorean triplet");

            for (var a = 1; a < 998; a++)
                for (var b = a; b < 999; b++)
                    for (var c = b; c < 1000; c++)
                        if (a + b + c == 1000 && (a * a) + (b * b) == (c * c))
                            return a * b * c;

            throw new ArithmeticException ("Solution not found");
        }
    }
}
