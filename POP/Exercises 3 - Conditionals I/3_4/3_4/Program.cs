using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your annual salary: ");
            string var0 = Console.ReadLine();
            int salary = int.Parse(var0);

            if (salary < 10000)
            {
                Console.WriteLine("No Tax Applicable.");
                Console.Write("Your Net Salary is {0}",salary);
            }
            else if (salary >= 10000 && salary <= 50000)
            {
                Console.WriteLine("Tax applied at 20%");
                double tax1 = salary * 0.2;
                double netSal1 = salary - tax1;
                Console.Write("Your Net Salary is {0}", netSal1);
            }
            else
            {
                Console.WriteLine("Tax applied at 40%");
                double tax2 = salary * 0.4;
                double netSal2 = salary - tax2;
                Console.Write("Your Net Salary is {0}", netSal2);
            }
            
            Console.ReadKey();
        }
    }
}
