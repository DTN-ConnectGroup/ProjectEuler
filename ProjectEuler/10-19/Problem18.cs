using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Project_Euler
{
	static class Problem18
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 18: Maximum path sum I");
			var r = 0;
			var sw = new Stopwatch();
			sw.Start();

			#region Setup
			var theNumbers =
@"75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";

			var linesArray = theNumbers.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
			var numList = new List<int[]>();

			foreach(string s in linesArray)
			{
				var numStringArray = (s.Split(new string[] { " " }, StringSplitOptions.None));
				var numIntArray = new int[numStringArray.Length];

				for(int i = 0; i < numStringArray.Length; i++)
					numIntArray[i] = Convert.ToInt32(numStringArray[i]);

				numList.Add(numIntArray);
			}
			#endregion
			numList.Reverse();

			for(int i = 0; i < numList.Count - 1; i++)
			{
				var fstArray = numList[i];
				var sndArray = numList[i + 1];
				for(int j = 0; j < sndArray.Length; j++)
					sndArray[j] += Math.Max(fstArray[j], fstArray[j + 1]);

				if(sndArray.Length == 1)
					r = sndArray[0];
			}

			// It totally looked the method up. Didnt think of it myself.
			// I implemented the code myself tho. This counts right ?

			sw.Stop();
			Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
			Console.WriteLine($"Result:		{r}");
			Console.ReadKey();
		}
	}
}
