using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number between 1 and 7: ");
            string var0 = Console.ReadLine();
            int num = int.Parse(var0);

            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday!");
                    break;
                case 2:
                    Console.WriteLine("Tuesday!");
                    break;
                case 3:
                    Console.WriteLine("Wednesday!");
                    break;
                case 4:
                    Console.WriteLine("Thursday!");
                    break;
                case 5:
                    Console.WriteLine("Friday!");
                    break;
                case 6:
                    Console.WriteLine("Saturday!");
                    break;
                case 7:
                    Console.WriteLine("Sunday!");
                    break;
                default:
                    Console.WriteLine("You entered an invalid number! Try again.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
