using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            string var = Console.ReadLine();
            int age = int.Parse(var);

            if (age >= 18 && age <= 30)
            {
                Console.WriteLine("Come on holiday with us!");
            }
            else if (age > 30)
            {
                Console.WriteLine("Go Bingo!");
            }
            else
            {
                Console.WriteLine("Go to Barcode!");
            }

            Console.ReadKey();
        }
    }
}
