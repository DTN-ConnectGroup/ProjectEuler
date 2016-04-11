using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Project_Euler
{
	static class Problem67
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 18: Maximum path sum II");
			var r = 0;
			var sw = new Stopwatch();
			sw.Start();

			#region Setup
			var theNumbers = System.IO.File.ReadAllText(@"..\..\Reffed files\p067_triangle.txt");

			var linesArray = theNumbers.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.None);
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
