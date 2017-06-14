using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            string s0 = Console.ReadLine();
            double a = double.Parse(s0);

            Console.Write("Please enter your second number: ");
            string s1 = Console.ReadLine();
            double b = double.Parse(s1);
            
            Console.Write("Please enter your third number: ");
            string s2 = Console.ReadLine();
            double c = double.Parse(s2);
            
            Console.Write("Please enter your fourth number: ");
            string s3 = Console.ReadLine();
            double d = double.Parse(s3);
            
            Console.Write("Please enter your fifth number: ");
            string s4 = Console.ReadLine();
            double r = double.Parse(s4);
            
            double part1 = 4 / (3 * (r + 34));
            Console.WriteLine("The answer to the first block of the problem is {0}!", part1);
            
            double part2 = 9 * (a + b * c) + 3;
            Console.WriteLine("The answer to the second block of the problem is {0}!", part2);
            
            double part3 = (d * (2 + a)) / (a + b * d);
            Console.WriteLine("The answer to the third block of the problem is {0}!", part3);
            
            double answer = part1 - part2 + part3;

            Console.WriteLine("The answer to the Hard Algebra Problem is {0:F2}!", answer);
            
            Console.ReadKey();
        }
    }
}
