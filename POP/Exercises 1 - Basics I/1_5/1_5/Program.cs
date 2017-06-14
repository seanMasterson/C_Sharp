using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer of your choice: ");
            string strVar = Console.ReadLine();
            int num = int.Parse(strVar);

            int newNum = num + 1;

            Console.WriteLine("Your new number is {0}!", newNum);

            Console.ReadKey();
        }
    }
}
