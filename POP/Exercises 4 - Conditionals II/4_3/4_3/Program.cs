using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool tryAgain = true;

            do
            {
                Console.Write("Please enter a value for the first edge of the triangle: ");
                string var0 = Console.ReadLine();
                double edge1 = double.Parse(var0);

                Console.Write("Please enter a value for the second edge of the triangle: ");
                string var1 = Console.ReadLine();
                double edge2 = double.Parse(var1);

                Console.Write("Please enter a value for the third edge of the triangle: ");
                string var2 = Console.ReadLine();
                double edge3 = double.Parse(var2);

                double perimeter = edge1 + edge2 + edge3;

                if ((edge1 + edge2 > edge3) && (edge1 + edge3 > edge2))
                {
                    Console.WriteLine("The perimeter of the triangle is {0:F2}.", perimeter);
                    tryAgain = false;
                }
                else
                {
                    Console.WriteLine("Error: Perimeter law has been defied. Please try again.");
                    Console.WriteLine();
                }
            } while (tryAgain);
            
            Console.ReadKey();
        }
    }
}
