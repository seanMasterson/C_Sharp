using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string star = "*";
            string twoStar = "**";

            Console.WriteLine("\t     " + star);
            Console.WriteLine("\t    " + star + twoStar);
            Console.WriteLine("\t   " + star + twoStar + twoStar);
            Console.WriteLine("\t  " + star + twoStar + twoStar + twoStar);
            Console.WriteLine("\t " + star + twoStar + twoStar + twoStar + twoStar);

            Console.ReadKey();
        }
    }
}
