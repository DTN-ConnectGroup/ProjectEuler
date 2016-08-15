using System;

namespace Project_Euler
{
    static class Problem22
    {
        public static int Run ()
        {
            Console.WriteLine ("Project Euler - 22: Names scores");
            var r = 0;

            var text = System.IO.File.ReadAllText (@"..\..\Reffed files\p022_names.txt");
            var nameArray = text.Split (new char[] { ',' });
            Array.Sort (nameArray);

            for (var i = 0; i < nameArray.Length; i++)
                r += nameArray[i].Substring (1, nameArray[i].Length - 2).GetAlphabeticalValue ();

            return r;
        }

        static int GetAlphabeticalValue (this string name)
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var r = 0;

            foreach (var c in name)
                r += (alphabet.IndexOf (c) + 1);

            return r;
        }
    }
}
