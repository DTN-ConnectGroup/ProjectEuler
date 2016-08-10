using System;

namespace Project_Euler
{
    static class Problem31
    {
        public static int Run()
        {
            Console.WriteLine("Project Euler - 31: Coin sums");

            var r = 1;

            for(int onePenny = 0; onePenny <= 200; onePenny++)
            {
                for(int twoPence = 0; twoPence <= 100; twoPence++)
                {
                    if(twoPence * 2 + onePenny > 200)
                        continue;

                    for(int fivePence = 0; fivePence <= 40; fivePence++)
                    {
                        if(200 < onePenny + 2 * twoPence + 5 * fivePence)
                            continue;

                        for(int tenPence = 0; tenPence <= 20; tenPence++)
                        {
                            if(200 < onePenny
                                     + 2 * twoPence
                                     + 5 * fivePence
                                     + 10 * tenPence)
                                continue;


                            for(int _20Pence = 0; _20Pence <= 10; _20Pence++)
                            {
                                if(200 < onePenny
                                         + 2 * twoPence
                                         + 5 * fivePence
                                         + 10 * tenPence
                                         + 20 * _20Pence)
                                    continue;
                                for(int _50Pence = 0; _50Pence <= 4; _50Pence++)
                                {
                                    if(200 < onePenny
                                            + 2 * twoPence
                                            + 5 * fivePence
                                            + 10 * tenPence
                                            + 20 * _20Pence
                                            + 50 * _50Pence)
                                        continue;

                                    for(int _1Pound = 0; _1Pound <= 2; _1Pound++)
                                    {
                                        var total =
                                            onePenny
                                            + 2 * twoPence
                                            + 5 * fivePence
                                            + 10 * tenPence
                                            + 20 * _20Pence
                                            + 50 * _50Pence
                                            + 100 * _1Pound;

                                        if(total == 200)
                                            r++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return r;
        }
    }
}
