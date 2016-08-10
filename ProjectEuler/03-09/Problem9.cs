using System;

namespace Project_Euler
{
    static class Problem9
    {
        public static double Run()
        {
            Console.WriteLine("Project Euler - 9: Special Pythagorean triplet");

            for(double a = 1; a < 1000; a++)
            {
                for(double b = a; b < 1000; b++)
                {
                    for(double c = b; c < 1000; c++)
                    {
                        if((a * a) + (b * b) == (c * c) && a + b + c == 1000)
                        {
                            return a * b * c;
                        }
                    }
                }
            }

            throw new ArithmeticException("Solution not found");
        }
    }
}
