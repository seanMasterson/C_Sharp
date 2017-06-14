using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            string var0 = Console.ReadLine();
            int num0 = int.Parse(var0);

            Console.Write("Please enter your second number: ");
            string var1 = Console.ReadLine();
            int num1 = int.Parse(var1);

            string answer;

            answer = (num0 < num1) ? "First number is less than the second." : "Second number is less than the first.";

            if (num0 == num1)
            {        
                Console.WriteLine("The numbers are equal.");
            }

            Console.ReadKey();
        }
    }
}
