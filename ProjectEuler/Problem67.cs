using System;
using System.Collections.Generic;

namespace Project_Euler
{
    static class Problem67
    {
        public static int Run ()
        {
            Console.WriteLine ("Project Euler - 18: Maximum path sum II");
            var r = 0;

            var theNumbers = System.IO.File.ReadAllText (@"..\..\Reffed files\p067_triangle.txt");
            var numList = Setup (theNumbers);

            numList.Reverse ();

            for (var i = 0; i < numList.Count - 1; i++)
            {
                var fstArray = numList[i];
                var sndArray = numList[i + 1];
                for (var j = 0; j < sndArray.Length; j++)
                    sndArray[j] += Math.Max (fstArray[j], fstArray[j + 1]);

                if (sndArray.Length == 1)
                    r = sndArray[0];
            }

            // It totally looked the method up. Didnt think of it myself.
            // I implemented the code myself tho. This counts right ?

            return r;
        }

        static List<int[]> Setup (string theNumbers)
        {
            var linesArray = theNumbers.Split (new string[] { "\n", "\r\n" }, StringSplitOptions.None);
            var numList = new List<int[]> ();

            foreach (var s in linesArray)
            {
                var numStringArray = (s.Split (new string[] { " " }, StringSplitOptions.None));
                var numIntArray = new int[numStringArray.Length];

                for (var i = 0; i < numStringArray.Length; i++)
                    numIntArray[i] = Convert.ToInt32 (numStringArray[i]);

                numList.Add (numIntArray);
            }

            return numList;
        }
    }
}
