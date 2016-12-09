using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MansBestFriend
{
    class Cat : Animal
    {
        private bool IsKitten;

        public Cat(bool isKitten) : base(typee: "?", age: 0, name: "?", gender: '?')
        {
            IsKitten = isKitten;
        }

        public bool Kitten_GS
        {
            get { return IsKitten; }
            set { IsKitten = value; }
        }
    }
}
