using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int CCV = 0;

            do
            {
                Console.WriteLine("Please enter your CCV number: ");
                string var0 = Console.ReadLine();
                CCV = int.Parse(var0);
            } while (CCV >= 100 || CCV <= 999);

            Console.WriteLine("Your CCV number is {0}", CCV);

            Console.ReadKey();
        }
    }
}
