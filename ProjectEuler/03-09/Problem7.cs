using System;
using System.Linq;
using EulerF;

namespace Project_Euler
{
    static class Problem7
    {
        public static long Run ()
        {
            Console.WriteLine ("Project Euler - 7: 10001st prime");

            return Helpers.PrimesSeq.Skip (10000).First ();
        }
    }
}
