using System;
using Humanizer;

namespace Project_Euler
{
    static class Problem17
    {
        public static int Run()
        {
            Console.WriteLine("Project Euler - 17: Number letter counts");
            var r = 0;

            for(var i = 1; i <= 1000; i++)
                r += i.ToWords().Dehumanize().Length;

            return r;
        }
    }
}
