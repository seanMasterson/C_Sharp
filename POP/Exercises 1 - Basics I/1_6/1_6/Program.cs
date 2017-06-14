using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            string var1 = Console.ReadLine();
            int num1 = int.Parse(var1);

            Console.Write("Please enter your second number: ");
            string var2 = Console.ReadLine();
            int num2 = int.Parse(var2);

            int sum = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);

            Console.ReadKey();
        }
    }
}
