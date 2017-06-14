using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius of your choice: ");
            string strVar = Console.ReadLine();
            double radius = int.Parse(strVar);

            double answer = CalculateArea(radius);

            Console.Write("The area of the circle is {0:F2}", answer);

            Console.ReadKey();
        }

        static double CalculateArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}
