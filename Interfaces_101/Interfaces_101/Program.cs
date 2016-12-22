using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_101
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt, Jr.
                Learning implementation of Interface
                Sunday, 12 - 18 - 2016*/


            FooBar fb = new FooBar();
            fb.SomeMethod();    //--Called the SomeMethod that belongs to FooBar class

            IFoo ifoo = fb as IFoo;     //--Cast Interface (iFoo)ifoo as a class like fb(FooBar)
            ifoo.SomeMethod();       //--Call the SomeMethod that belongs to the IFoo Interface

            IBar ibar = fb as IBar;     //--Cast Interface (IBar)ibar as a class like fb(FooBar)
            ibar.SomeMethod();      //--Call the SomeMethod that belongs to the IBar Interface
            ///////////////////////////////////////////////////////////
            /*
            //--Instance of Document class
            Document document = new Document("Test Document");

            //--Instantiate methods
            document.Save();
            document.Load();
            document.Encrypt();
            document.Decrypt();
            document.NeedsSave = false;
            
            //-----------------------------------------------------------------//
            //--Using the 'is' operator to test if document is IStorable
            
             * if (document is IStorable)
            {
                document.Save();
            }
            else
            {
                Console.WriteLine("Not IStorable!");
            }

            //--Using the 'as' operator to cast
            IStorable intStore = document as IStorable;
            if (intStore != null)
            {
                document.Load();
            }
            */
            //-----------------------------------------------------------------//

            Console.WriteLine("\r\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
