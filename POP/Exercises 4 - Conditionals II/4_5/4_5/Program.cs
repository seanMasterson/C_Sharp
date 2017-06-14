using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool tryAgain = true;

            while (tryAgain)
            {
                Console.Write("Press a number between 1 and 12 to generate a month! : ");
                string var0 = Console.ReadLine();
                int num = int.Parse(var0);
               
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("{0} = January", num);
                            tryAgain = false;
                            break;
                        case 2:
                            Console.WriteLine("{0} = February", num);
                            tryAgain = false;
                            break;
                        case 3:
                            Console.WriteLine("{0} = March", num);
                            tryAgain = false;
                            break;
                        case 4:
                            Console.WriteLine("{0} = April", num);
                            tryAgain = false;
                            break;
                        case 5:
                            Console.WriteLine("{0} = May", num);
                            tryAgain = false;
                            break;
                        case 6:
                            Console.WriteLine("{0} = June", num);
                            tryAgain = false;
                            break;
                        case 7:
                            Console.WriteLine("{0} = July", num);
                            tryAgain = false;
                            break;
                        case 8:
                            Console.WriteLine("{0} = August", num);
                            tryAgain = false;
                            break;
                        case 9:
                            Console.WriteLine("{0} = September", num);
                            tryAgain = false;
                            break;
                        case 10:
                            Console.WriteLine("{0} = October", num);
                            tryAgain = false;
                            break;
                        case 11:
                            Console.WriteLine("{0} = November", num);
                            tryAgain = false;
                            break;
                        case 12:
                            Console.WriteLine("{0} = December", num);
                            tryAgain = false;
                            break;
                        default:
                            Console.WriteLine("That is not a valid number, try again.");                           
                            break;
                    }                
            }

            Console.ReadKey();
        }
    }
}
