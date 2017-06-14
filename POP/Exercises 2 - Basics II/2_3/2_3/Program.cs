using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            string var0 = Console.ReadLine();
            int a = int.Parse(var0);

            Console.Write("Please enter your first number: ");
            string var1 = Console.ReadLine();
            int b = int.Parse(var1);
           
            int power = a * b * b;

            Console.Write("{0} * {1} * {2} = {3}", a, b, b, power);

            Console.ReadKey();
        }
    }
}
