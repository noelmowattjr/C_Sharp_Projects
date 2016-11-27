using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Ferrari : Car
    {
        //--fields unique to Ferrari
        public readonly int Speeds;
        public readonly string Color;

        //--Subclass Ferrari inherits from Car class
        public Ferrari(int numOfWheels, int numOfSeats, int speeds, string color) : base(numOfWheels, numOfSeats)
        {
            Speeds = speeds;
            Color = color;
        }
    }
}
