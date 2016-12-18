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

            //--Instance of Document class
            Document document = new Document("Test Document");

            document.Save();    //--Exercising the Save method
            document.Load();    //--Exercising the Load method
            document.NeedsSave = false;     //--Exercising the NeedsSave property

            Console.WriteLine("\r\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
