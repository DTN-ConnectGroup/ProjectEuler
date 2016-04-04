using System;
using System.Diagnostics;

namespace Project_Euler
{
	static class Problem22
	{
		public static void Run()
		{
			Console.WriteLine("Project Euler - 22: Names scores");
			var r = 0;
			var sw = new Stopwatch();
			sw.Start();

			var text = System.IO.File.ReadAllText(@"..\..\Reffed files\p022_names.txt");
			var nameArray = text.Split(new char[] { ',' });
			Array.Sort(nameArray);

			for(int i = 0; i < nameArray.Length; i++)
			{
				var name = nameArray[i].Substring(1, nameArray[i].Length - 2);
				var abcValue = GetAlphabeticalValue(name);
				r += abcValue * (i + 1);
			}

			sw.Stop();
			Console.WriteLine($"Time elapsed:	{sw.ElapsedMilliseconds}ms");
			Console.WriteLine($"Result:		{r}");
			Console.ReadKey();
		}

		private static int GetAlphabeticalValue(string name)
		{
			const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			var r = 0;

			foreach(char c in name)
				r += (alphabet.IndexOf(c) + 1);

			return r;
		}
	}
}
