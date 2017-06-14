using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numClass = 0;
            
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a student's grade: ");
                string gradeNum = Console.ReadLine();
                int grade = int.Parse(gradeNum);
                numClass += grade;
            }

            double average = numClass / 10;
            Console.WriteLine("The class average is {0}", average);

            Console.ReadKey();
        }
    }
}
