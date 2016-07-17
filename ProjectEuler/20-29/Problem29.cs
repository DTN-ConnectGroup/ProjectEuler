using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Euler
{
    static class Problem29
    {
        public static int Run()
        {
            Console.WriteLine("Project Euler - 29: Distinct powers");


            /* F# solution .. much nicer

            seq {
                    for a in [2.0..1.0..100.0] do
                                    for b in [2.0..1.0..100.0] do
                                                    yield(a * *b)
            }
            |> Set.ofSeq
            |> Set.count

            */

            return new HashSet<double>(ListOfPowers(0, 100)).Count;
        }

        static IEnumerable<double> ListOfPowers(int min, int max)
        {
            var range = Enumerable.Range(min, max);

            foreach(var i in range)
                foreach(var j in range)
                    yield return Math.Pow(i, j);
        }
    }
}
