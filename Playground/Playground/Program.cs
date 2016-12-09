using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt, Jr.
                Program - Playground
                */

            Console.Write("Enter number between -1 and 21: ");
            int v;

            
            try
            {
                //--if number, converts t int and stores user's response
                v = int.Parse(Console.ReadLine());
                

                //--throw exception if number is out of range
                if (v < 0 || v > 20)
                {
                    throw new Exception();
                }
                else
                {
                    Console.WriteLine(string.Format("You entered {0} Awesome!", v));
                }
            }
            catch (Exception)
            {
                //--v = int.Parse(Console.ReadLine());
                Console.WriteLine("out of range! Enter a number!");
            }
        }
    }
}
