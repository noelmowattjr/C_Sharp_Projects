using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MansBestFriend
{
    class Dog : Animal
    {
        private bool IsTrained;

        public Dog(bool isTrained) : base(typee:"?",age:0, name:"?", gender:'?')
        {
            IsTrained = isTrained;
        }

        public bool Trained_GS
        {
            get { return IsTrained; }
            set { IsTrained = value; }
        }
    }
}
