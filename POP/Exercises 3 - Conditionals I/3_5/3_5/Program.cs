using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number between 1 and 4: ");
            string var0 = Console.ReadLine();
            int num = int.Parse(var0);

            switch (num)
            {
                case 1:
                    Console.WriteLine("Diamonds!");
                    break;
                case 2:
                    Console.WriteLine("Hearts!");
                    break;
                case 3:
                    Console.WriteLine("Clubs!");
                    break;
                case 4:
                    Console.WriteLine("Spades!");
                    break;
                default:
                    Console.WriteLine("You entered an invalid number! Please try again.");
                    break;
            }
                        
            Console.ReadKey();
        }
    }
}
