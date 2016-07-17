using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Project_Euler
{
    static class Problem29
    {
        public static void Run()
        {
            Console.WriteLine("Project Euler - 29: Distinct powers");
            var r = 0d;
            var sw = new Stopwatch();
            sw.Start();

            /* F# solution .. much shorter

            seq {
                    for a in [2.0..1.0..100.0] do
                                    for b in [2.0..1.0..100.0] do
                                                    yield(a * *b)
            }
            |> Set.ofSeq
            |> Set.count

            */

            r = new HashSet<double>(ListOfPowers(0, 100)).Count;

            sw.Stop();
            Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
            Console.WriteLine($"Result:		{r}");
            Console.ReadKey();
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
