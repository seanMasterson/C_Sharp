using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryAgain = true;

            while(tryAgain)
            {
                Console.Write("Guess a number, between 0 and 20: ");
                string var0 = Console.ReadLine();
                int numGuess = int.Parse(var0);

                int numAnswer = 14;

                if (numGuess < 0 || numGuess > 20)
                {
                    Console.WriteLine("That is not a valid number. Please try again!");
                    Console.WriteLine();
                }
                else if (numGuess < numAnswer)
                {
                    Console.WriteLine("Your guess is too low, try again.");
                    Console.WriteLine("The correct number is {0}.", numAnswer);
                    Console.WriteLine();
                }
                else if (numGuess > numAnswer)
                {
                    Console.WriteLine("You guess is too high, try again.");
                    Console.WriteLine("The correct number is {0}.", numAnswer);
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("Well Done! You guessed correctly!");
                    Console.WriteLine("The correct number is {0}.", numAnswer);
                    tryAgain = false;
                }
            }
            
            Console.ReadKey();
        }
    }
}
