using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferrari mycar = new Ferrari(4,4,250,"red","Ferrari");

            var name = mycar.Model;
            var colr = mycar.Color;
            var fourSeater = mycar.NumOfSeats;
            var speed = mycar.Speeds;

            Console.WriteLine("I drive a {0} {1}, it's a {2} seater and goes {3} mph in 60 secs", colr, name, fourSeater,speed);
        }
    }
}
