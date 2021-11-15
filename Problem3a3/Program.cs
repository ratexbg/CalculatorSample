using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3a3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;
            const int DIVIDER = 4;
            int total  = 0;
            int positivCases = 0;

            for (int n1 = 1; n1 < 5; n1++) //first digit
            {
                for (int n2 = 4; n2 < 9; n2++)
                {
                    for (int n3 = 3; n3 < 8; n3++)
                    {
                        for (int n4 = 6; n4 < 9; n4++)
                        {

                            for (int n5 = 2; n5 < 8; n5++)
                            {
                                number = n5 + n4 * 10 + n3 * 100 + n2 * 1_000 + n1 * 10_000;
                                if (number % DIVIDER == 0)
                                {
                                    positivCases++;
                                }
                                total++;
                            }

                        }

                    }
                }
            }
            Console.WriteLine($"Total cases {total}");
            Console.WriteLine($"Positive cases {positivCases}");
            Console.WriteLine($"Probability{((double)positivCases/total):F2}");
        }
    }
}
