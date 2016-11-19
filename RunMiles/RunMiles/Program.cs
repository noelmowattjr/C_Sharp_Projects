using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunMiles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt, Jr.
                Program: Run Miles*/

            // Description: Program keeps track of miles user runs and adds it to total amount

            bool keepItGoing = true;

            while (keepItGoing)
            {
                //--Prompt user for miles ran
                Console.Write("Miles ran today? ");
                string entry = Console.ReadLine();

                //--Handle the user's entry for correctness and error if number not entered
                try
                {
                    double milesEntered = double.Parse(entry);
                }
                catch(FormatException)
                {
                    Console.Write("Invalid!");
                    continue;     //--starts loop over from beginning
                }
            }
        }
    }
}
