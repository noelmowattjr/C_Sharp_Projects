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

            double milesTotal = 0;
            bool keepItGoing = true;

            while (keepItGoing)
            {
                //--Prompt user for miles ran
                Console.Write("Enter miles ran today or enter \"QUIT\" to exit: ");
                string entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    //--while loop ends - Program ends
                    keepItGoing = false;
                    continue;
                }
                else
                {
                    //--Program continues--//

                    try
                    {
                        double miles = double.Parse(entry);

                        //--Give user feedback on entered miles


                        //--Add miles entered to miles total
                        milesTotal = milesTotal + miles;

                        Console.WriteLine("You've ran a total of {0} miles today", milesTotal);
                    }
                    catch (FormatException)
                    {
                        Console.Write("Invalid!");
                        continue;     //--starts loop over from beginning
                    }
                }
            }
            //--Goodbye message
            Console.WriteLine("Goodbye!");
        }
    }
}
