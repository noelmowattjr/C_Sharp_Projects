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

            //--Instantiate Pet Class
            Dog dog = new Dog(isTrained: true); Cat cat = new Cat(isKitten: true); Monkey monkey = new Monkey(isCircMonkey: true);
 
            while (keepPlaying)
            {
                //--Name Prompt
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                string greet = GoodDay(name);  //--Greeting according to time of day

                //--Continue Program or Exit
                Console.Write("Now to contnue enter \"Yes\" or to exit, type \"No\": ");
                string yesno = Console.ReadLine();

                //--Validation for Yes or No entries
                while (yesno.ToLower() != "yes" && yesno.ToLower() != "no"){ Console.Write("INVALID ENTRY!\r\nOnly enter (YES/NO): "); yesno = Console.ReadLine();}

                if (yesno.ToLower() == "yes")
                {
                    //--CONTINUE

                    //--Choose your Pet
                    Console.Write("Dog - Cat - Monkey\r\nPick a pet: ");
                    string petChoice = Console.ReadLine();


                    //--Name your Pet
                    //--Choose three times of the day you will feed your Pet
                    //--What time of day will you bathe your Pet?
                    //--Time of day you will walk your Pet?
                    //--Set a bedtime for Pet
                    //--Program settings saved  - Run Program!

                }
                else if (yesno.ToLower() == "no")
                {
                    //--EXIT
                    break;
                }
            }
            Console.WriteLine("Goodbye!... =(");




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
