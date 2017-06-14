using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int morethan0 = 0;
            int lessthan0 = 0;            
            int num = 0;

            do
            {
                Console.WriteLine("Enter as many integers of your choice. Press 0 to see them all: ");
                string var = Console.ReadLine();
                num = int.Parse(var);
                if (num > 0)
                {
                    morethan0++;
                }   
                else if (num < 0)
                {
                    lessthan0--;
                }                     
            } while (num != 0);

            Console.WriteLine("The number of positives = {0} and negatives = {1}.", morethan0, lessthan0);

            Console.ReadKey();
        }
    }
}
