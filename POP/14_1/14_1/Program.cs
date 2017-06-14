using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1
{
    class Program
    {
        // Q.1
        public enum DaysOfTheWeek
        {
            Monday = 1, Tuesday, Wednesday, Thursday,
            Friday, Saturday, Sunday
        };

        // Q.2
        public enum MonthsOfTheYear
        {
            January = 1, February, March, April, May, June,
            July, August, September, October, November, December
        }

        static void Main(string[] args)
        {
            MonthsOfTheYear march = MonthsOfTheYear.March;
            Console.WriteLine("{0} is the month of maying.\n", march);

            bool b1 = true;
            do
            {
                DaysOfTheWeek favouriteDay;
                Console.Write("Enter a number for your favourite day: ");
                string strVar = Console.ReadLine();
                                
                if (Enum.TryParse(strVar, out favouriteDay))
                {
                    Console.WriteLine("{0} is your favourite day.", favouriteDay);
                    b1 = false;
                }
                else
                {
                    Console.WriteLine("Try Again!");
                    b1 = true;
                }                               
            } while(b1);

            Console.ReadKey();
        }
    }
}
