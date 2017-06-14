using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numArray = new double[10];

            double sum = 0d;
            double num;

            for(int n = 0; n < 10; n++)
            {
                Console.WriteLine("Please enter number {0}: ", n + 1);
                string strVar = Console.ReadLine();
                num = double.Parse(strVar);
                numArray[n] = num;
                sum += num;
            }

            Console.WriteLine("The sum of the numbers entered is {0}", sum);

            int average = (int)sum / 10;
            Console.WriteLine("The average of the numbers entered is {0}", average);

            Console.WriteLine("The numbers entered were: \n");
            for (int n = 0; n < 10; n++)
            {
                Console.WriteLine("{0}", numArray[n]);
            }
            
            Console.ReadKey();
        }
    }
}
