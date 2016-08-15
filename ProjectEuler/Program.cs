using System;
using System.Diagnostics;

namespace Project_Euler
{
    class Program
    {
        static void Main()
        {
            var sw = Stopwatch.StartNew();

            var r = Problem7.Run();

            sw.Stop();
            Console.WriteLine($"Result:		{r}");
            Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
            Console.ReadKey();
        }
    }
}
