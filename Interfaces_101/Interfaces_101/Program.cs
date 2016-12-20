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
            int one = 1;
            
            //-----------------------------------------------------------------//
            //--Using the 'is' operator to test if document is IStorable
            if (one is IStorable)
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

            //--Cast 3 more example
            IStorable doc1 = document as IStorable;
            IStorable doc2 = document as IStorable;
            IStorable doc3 = document as IStorable;

            if (doc1 != null)
            {
                document.Load();
            }

            //-----------------------------------------------------------------//

            Console.WriteLine("\r\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
