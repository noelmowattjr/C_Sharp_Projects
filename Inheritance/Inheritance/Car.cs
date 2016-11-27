using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car
    {
        public readonly int NumOfWheels;
        public readonly int NumOfSeats;

        //--constructor
        public Car(int numOfWheels, int numOfSeats)
        {
            NumOfWheels = numOfWheels;
            NumOfSeats = numOfSeats;
        }
    }
}
