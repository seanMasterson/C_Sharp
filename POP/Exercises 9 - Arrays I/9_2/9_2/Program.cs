using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
    class Program
    {
        const int SIZE = 5;

        static void Main(string[] args)
        {
            int[] numArray = new int[SIZE];

            for(int i = 0; i < SIZE; i++)
            {
                Console.WriteLine("Please enter an integer of your choice: \t");
                string strVar = Console.ReadLine();
                int num = int.Parse(strVar);
                numArray[i] = num;
            }

            Console.WriteLine("Your numbers in order are: ");
            foreach(int val in numArray)
            {               
                Console.WriteLine("\t{0}",val.ToString());
            }

            Console.WriteLine("Your numbers in the reverse order are:");
            for (int i = numArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("\t{0}", numArray[i].ToString());
            }
            Console.ReadKey();
        }
    }
}
