using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a lower bound: ");
            string var0 = Console.ReadLine();
            int lowerBound = int.Parse(var0);

            Console.WriteLine();

            Console.Write("Enter an upper bound: ");
            string var1 = Console.ReadLine();
            int upperBound = int.Parse(var1);

            int answer = SumRange(lowerBound, upperBound);

            Console.WriteLine("The sum of the bound is {0}", answer);

            Console.ReadKey();
        }

        static int SumRange(int lowerBound, int upperBound)
        {
            int sum = 0;

            for (int i = lowerBound; i <= upperBound; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
