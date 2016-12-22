using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_101
{
    //--Created 2 Interfaces that define the same method--//
    interface IFoo
    {
        void SomeMethod();
    }

    interface IBar
    {
        void SomeMethod();
    }

    //--Class FooBar - implementing the 2 Interfaces above
    class FooBar : IFoo, IBar
    {
        //--Class method
        public void SomeMethod()
        {
            Console.WriteLine("This is the class method!");
        }
    }
}
