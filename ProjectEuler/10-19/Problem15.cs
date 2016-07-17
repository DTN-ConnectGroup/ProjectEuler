using System;
using System.Diagnostics;
using static System.Math;

//namespace Project_Euler
//{
//	static class Problem15
//	{
//		public static void Run()
//		{
//			Console.WriteLine("Project Euler - 15: Lattice paths");
//			int r = 0;
//			var sw = new Stopwatch();
//			sw.Start();

//			var n = 3;
//			for (int i = n; i >= 2; i--)
//				r += DeFacto(n);

// DRAFT SOLUTION DOESNT WORK

//			sw.Stop();
//			Console.WriteLine("Time elapsed:	{0}", sw.ElapsedMilliseconds);
//			Console.WriteLine("Result:		{0}", r);
//			Console.ReadKey();
//		}
//		static int DeFacto(int n)
//		{
//			if (n == 2)
//				return 6;

//			var r = 0;
//			for (int i = n; i >= 2; i--)
//			{
//				r += AddFacto(i);
//			}

//			return r;
//		}
//		static int AddFacto(int n)
//		{
//			if (n < 2)
//				return 1;
//			if (n == 2)
//				return 6;
//			return n + 1 + AddFacto(n - 1);
//		}
//	}
//}

namespace Project_Euler
{
    static class Problem15
    {
        public static long Run()
        {
            Console.WriteLine("Project Euler - 15: Lattice paths");
            long r = 0;

            // This works but is extremely inefficient
            // Didn't end up using either solution, but looking up the math behind it.
            // https://en.wikipedia.org/wiki/Lattice_path
            // So the answer is 40! / (20! * 20!) . Used WolframAlpha to give me a number quickly.

            long n = 20;

            var m = Pow(2, 2 * n) - (Pow(2, n) - 1);
            var sm = Convert.ToString((long)m, 2);

            for(long i = (int)(Pow(2, n) - 1); i < m; i += 2)
            {
                var s = Convert.ToString(i, 2);

                // stolen from http://stackoverflow.com/questions/5340564/counting-how-many-times-a-certain-char-appears-in-a-string-before-any-other-char
                var count = NumberOfOnes(s, '1');
                if(count == n)
                    r++;
            }

            r *= 2;

            return r;
        }

        public static int NumberOfOnes(string text, char c)
        {
            int count = 0;

            foreach(char ch in text)
                if(ch.Equals(c))
                    count++;

            return count;
        }
    }
}
