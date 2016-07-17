using System;
using System.Diagnostics;

namespace Project_Euler
{
    class Program
    {
        static void Main()
        {
            var sw = new Stopwatch();
            sw.Start();

            var r = Problem29.Run();

            sw.Stop();
            Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
            Console.WriteLine($"Result:		{r}");
            Console.ReadKey();
        }
    }
}
