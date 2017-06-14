using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            string var1 = Console.ReadLine();
            int num1 = int.Parse(var1);

            int newNum = num1 + 1;

            Console.WriteLine("Your new first number is {0}!", newNum);

            Console.Write("Please enter your second number: ");
            string var2 = Console.ReadLine();
            int num2 = int.Parse(var2);

            int sum = newNum + num2;

            Console.WriteLine("{0} + {1} = {2}", newNum, num2, sum);

            Console.ReadKey();
        }
    }
}
