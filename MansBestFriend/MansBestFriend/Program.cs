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

            bool keepPlaying = true;
            //keepPlaying = false;

            //--Instantiate Pet Class
            Dog dog = new Dog(isTrained: true); Cat cat = new Cat(isKitten: true); Monkey monkey = new Monkey(isCircMonkey: true);
 
            
            
            while (keepPlaying)
            {
                //--Name Prompt
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                string greet = GoodDay(name);  //--Greeting according to time of day

                //--Greet & and welcome user
                Console.WriteLine();
                keepPlaying = false;
                //--Choose your Pet
                

                //--Name your Pet
                //--Choose three times of the day you will feed your Pet
                //--What time of day will you bathe your Pet?
                //--Time of day you will walk your Pet?
                //--Set a bedtime for Pet
                //--Program settings saved  - Run Program!
            }




        }

        //--Greeting User according to time of day
        public static string GoodDay(string n)
        {
            DateTime timeNow = new DateTime();
            timeNow = DateTime.Now;
            string msg;
            
            if (timeNow.Hour >= 0 && timeNow.Hour < 12) //--Morning condition
            {
                msg = "Good morning " + n + " and welcome!";
                Console.WriteLine(msg);
            }
            else if (timeNow.Hour >= 12 && timeNow.Hour < 17)
            {
                msg = "Good afternoon " + n + " and welcome!";
                Console.WriteLine(msg);
            }
            else if (timeNow.Hour >= 17 && timeNow.Hour < 20)
            {
                msg = "Good evening " + n + " and welcome!";
                Console.WriteLine(msg);
            }
            else
            {
                msg = "Good night " + n + " and welcome!";
                Console.WriteLine(msg); ;
            }
            return msg;
        }
    }
}
