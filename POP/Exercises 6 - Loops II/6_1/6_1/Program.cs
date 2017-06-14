using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Please enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("{0}", num % 10);
                num = num / 10;
            }
            while (num != 0);

            Console.ReadKey();
        }
    }
}
