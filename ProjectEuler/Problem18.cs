using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
	static class Problem18
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 18: Maximum path sum I"); // UNSOLVED YET
			var r = 0;
			var sw = new Stopwatch();
			sw.Start();

			#region Setup
			//			var theNumbers =
			//@"75
			//95 64
			//17 47 82
			//18 35 87 10
			//20 04 82 47 65
			//19 01 23 75 03 34
			//88 02 77 73 07 63 67
			//99 65 04 28 06 16 70 92
			//41 41 26 56 83 40 80 70 33
			//41 48 72 33 47 32 37 16 94 29
			//53 71 44 65 25 43 91 52 97 51 14
			//70 11 33 28 77 73 17 78 39 68 17 57
			//91 71 52 38 17 14 91 43 58 50 27 29 48
			//63 66 04 68 89 53 67 30 73 16 69 87 40 31
			//04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";

			//			var linesArray = theNumbers.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
			//			var numList = new List<int[]>();

			//			foreach(string s in linesArray)
			//			{
			//				var numStringArray = (s.Split(new string[] { " " }, StringSplitOptions.None));
			//				var numIntArray = new int[numStringArray.Length];

			//				for(int i = 0; i < numStringArray.Length; i++)
			//					numIntArray[i] = Convert.ToInt32(numStringArray[i]);

			//				numList.Add(numIntArray);
			//			}
			#endregion

			//			var pointer = 0;

			//			for(int i = 0; i < numList.Count; i++)
			//			{
			//				var row = numList[i];
			//				r += row[pointer];

			//				var a0 = GetAverage(numList, i + 1, pointer);
			//				var a1 = GetAverage(numList, i + 1, pointer + 1);

			//				if(a1 > a0)
			//					pointer++;
			//			}

			sw.Stop();
			Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
			Console.WriteLine($"Result:		{r}");
			Console.ReadKey();
		}

		//static double GetAverage(List<int[]> numList, int rowIndex, int headIndex)
		//{
		//	var rList = new List<double>();
		//	rList.Add(0d);

		//	for(int i = rowIndex; i < numList.Count; i++)
		//	{
		//		var row = numList[i];
		//		var internalRList = new List<int>();
		//		for(int n = 0; n < i - rowIndex + 1; n++)
		//		{
		//			var j = headIndex + n;
		//			internalRList.Add(0);
		//			internalRList.Add(row[j]);
		//		}

		//		rList.Add(internalRList.Average());
		//	}

		//	return rList.Average();
		//}
	}
}
