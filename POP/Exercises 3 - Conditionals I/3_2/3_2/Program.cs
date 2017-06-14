using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            string var = Console.ReadLine();        
            int age = int.Parse(var);
           
            string answer;

            answer = (age >= 18) ? "You are eligible to vote!" : "You are not eligible to vote!";

            Console.ReadKey();
        }
    }
}
