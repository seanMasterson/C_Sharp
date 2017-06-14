using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 3.5;
            int num2 = 4;
            double num3 = 0.5;
            double num4 = 2.5;

            double answer = num1 * num2 * num3 - num4;

            Console.Write("{0} * {1} * {2} - {3} = {4}", num1, num2, num3, num4, answer);

            Console.ReadKey();
        }
    }
}
