using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MansBestFriend
{
    class Monkey : Animal
    {
        public bool IsCircusMonkey;

        public Monkey(bool isCircMonkey) : base(typee: "?", age: 0, name: "?", gender: '?')
        {
            IsCircusMonkey = isCircMonkey;
        }

        public bool CircusTrained_GS
        {
            get { return IsCircusMonkey; }
            set { IsCircusMonkey = value; }
        }
    }
}
