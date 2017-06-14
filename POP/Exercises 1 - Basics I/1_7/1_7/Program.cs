using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            string var1 = Console.ReadLine();
            double num1 = double.Parse(var1);

            Console.Write("Please enter your second number: ");
            string var2 = Console.ReadLine();
            double num2 = double.Parse(var2);

            double quotient = num1 / num2;

            Console.WriteLine("{0} / {1} = {2}", num1, num2, quotient);

            Console.ReadKey();
        }
    }
}
