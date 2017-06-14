using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a value of time in seconds: ");
            string timeVal = Console.ReadLine();
            int time = int.Parse(timeVal);

            double minutes = time / 60;

            double seconds = time % 60;

            Console.WriteLine("The time is {0} minutes and {1} seconds.", minutes, seconds);

            Console.ReadKey();
        }
    }
}
