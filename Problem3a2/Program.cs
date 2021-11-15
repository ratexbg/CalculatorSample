using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3a2
{
    class Program
    {
        static void Main(string[] args)
        {

            double x;
            double term;
            double partialSum;
            int n;
            double accuracy;

            x = Math.PI / 4;
            accuracy = 0.0000001;
            term = 1.0;
            partialSum = term;

            n = 1;
            do
            {
                term = -term * x * x/ ((n + 1)* n);
                partialSum += term;
                n = n + 2;

            } while (Math.Abs(term)>accuracy);

            Console.WriteLine($"Accurate Value Cos:{Math.Cos(x)} for x= {x}");
            Console.WriteLine($"Aprroximate Value Cos:{partialSum} for x= {x}");
        }
    }
}
