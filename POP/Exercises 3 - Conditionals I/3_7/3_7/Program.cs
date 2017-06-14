using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Calculator!");

            Console.Write("Please press 1 to do addition, 2 for subtraction, 3 for multiplication, and 4 for division: ");
            string var0 = Console.ReadLine();
            int num0 = int.Parse(var0);

            if (num0 > 0 && num0 <= 4)
            {
                if (num0 == 1)
                {
                    Console.WriteLine("Please enter two numbers to add: ");
                }
                else if (num0 == 2)
                {
                    Console.WriteLine("Please enter two numbers to subtract: ");
                }
                else if (num0 == 3)
                {
                    Console.WriteLine("Please enter two numbers to multiply: ");
                }
                else if (num0 == 4)
                {
                    Console.WriteLine("Please enter two numbers to divide: ");
                }
                else
                {
                    Console.WriteLine("That option is not supported! Try again.");
                }
            }

            Console.ReadKey();
        }
    }
}
