using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2
{
    class Program
    {
        public enum Months {Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sept, Oct, Nov, Dec };

        static void Main(string[] args)
        {
            Months favMonth = Months.Mar;

            Console.WriteLine("You favourite month is {0}", favMonth);
            Console.ReadKey();
        }
    }
}
