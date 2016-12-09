using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MansBestFriend
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt, Jr.
                Date: 12 - 09 - 2016
                Project: Man's Best Friend  
                Brief Desc: User chooses a one of three animals for a pet - Monkey, Cat, or Dog*/

            //--Instantiate Pet Class
            Dog dog = new Dog(isTrained: true);
            Cat cat = new Cat(isKitten: true);
            Monkey monkey = new Monkey(isCircMonkey: true);

            //--Choose your Pet
            Console.WriteLine("");
            Console.Write("Choose your Pet: ");


            //--Name your Pet
            //--Choose three times of the day you will feed your Pet
            //--What time of day will you bathe your Pet?
            //--Time of day you will walk your Pet?
            //--Set a bedtime for Pet
            //--Program settings saved  - Run Program!

        }
    }
}
