using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryAgain = true;

            do
            {
                Console.Write("Please enter a number between 0 and 1000: ");
                string var0 = Console.ReadLine();
                int num = int.Parse(var0);

                if (num < 0 || num > 1000)
                {
                    Console.WriteLine("That is not a valid number! Please try again.\n");
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine("The number you entered is even.\n");
                    Console.WriteLine();                              
                }
                else
                {
                    Console.WriteLine("The number you entered is odd. \n");
                    Console.WriteLine();                                                         
                }

                Console.Write("Would you like to try again? (Y/N): ");
                string str0 = Console.ReadLine();              
                if (str0.ToUpper().Equals("Y"))
                {
                    tryAgain = true;
                }
                if (str0.ToUpper().Equals("N"))
                {
                    tryAgain = false;
                }
            } while (tryAgain);

            Console.WriteLine("Good Bye!");
            Console.ReadKey();
        }
    }
}
