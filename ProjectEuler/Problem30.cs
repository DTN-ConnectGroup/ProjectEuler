using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Euler
{
    static class Problem30
    {
        public static int Run()
        {
            Console.WriteLine("Project Euler - 30: Digit fifth powers");

            return Enumerable.Range(2, 1000000)
                             .Where(IsSumOfPowers)
                             .Sum();
        }

        static bool IsSumOfPowers(int x) => x == SumOfDigitPowers(x);

        static int SumOfDigitPowers(int x) => Digits(x).Select(FifthPower).Sum();

        // Stolen from http://stackoverflow.com/questions/829174/is-there-an-easy-way-to-turn-an-int-into-an-array-of-ints-of-each-digit
        static IEnumerable<int> Digits(this int number)
        {
            do
            {
                yield return number % 10;
                number /= 10;
            }
            while(number > 0);
        }

        static int FifthPower(int x) => (int)Math.Pow(x, 5);
    }
}

/* F# solution


let fifthPower x = x * x * x * x * x

let rec digits x =
    seq {
        let single = x % 10

        yield single

        match((x - singles ) / 10) with 
        | 0 -> ()
        | n -> yield! digits n
    }

let sumOfDigitPowers x =
    digits x
    |> Seq.map fifthPower
    |> Seq.sum

let isSumOfPowers x = x = (sumOfDigitPowers x)

#time "on"

seq { 2..1000000 }
|> Seq.filter isSumOfPowers
|> Seq.sum

*/
