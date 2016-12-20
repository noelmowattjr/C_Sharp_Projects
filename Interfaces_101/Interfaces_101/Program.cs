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
            
            //-----------------------------------------------------------------//
            //--Using the 'is' operator to test if document is IStorable
            if (document is IStorable)
            {
                document.Save();
            }

            //--Using the 'as' operator to cast
            IStorable intStore = document as IStorable;
            if (intStore != null)
            {
                document.Load();
            }
            //-----------------------------------------------------------------//

            Console.WriteLine("\r\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
