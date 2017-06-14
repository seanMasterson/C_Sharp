using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the price of the first rice bag:");
            string var0 = Console.ReadLine();
            double p1 = double.Parse(var0);

            Console.Write("Please enter the weight of the first rice bag: ");
            string var1 = Console.ReadLine();
            double w1 = double.Parse(var1);

            Console.WriteLine("Please enter the price of the second rice bag: ");
            string var2 = Console.ReadLine();
            double p2 = double.Parse(var2);

            Console.Write("Please enter the weight of the second rice bag: ");
            string var3 = Console.ReadLine();
            double w2 = double.Parse(var3);

            if (p1 > p2 || w1 > w2)
            {
                Console.WriteLine("Rice Bag 1 has better value!");
            }         
            else 
            {
                Console.WriteLine("Rice Bag 2 has better value!");
            }

            Console.ReadKey();
        }
    }
}
