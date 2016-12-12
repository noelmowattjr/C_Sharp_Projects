using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt, Jr.
                Bubble Sort
                Monday, 12 - 12 - 2016
                */

            //--items to sort
            int[] numbers = { 9,10,1,5,3,7,2,3,6 };
            bool flag = true;
            int temp;
            int numLength = numbers.Length;

            //--Sorting numbers array
            for (int a = 1; (a <= (numLength -1)) && flag; a++)
            {
                flag = false;
                for (int b = 0; b < (numLength - 1); b++)
                {
                    if (numbers[b + 1] > numbers[b])
                    {
                        temp = numbers[b];
                        numbers[b] = numbers[b + 1];
                        numbers[b + 1] = temp;
                        flag = true;
                    }
                }
            }

            //--Sorted array in descending order from left --> right
            foreach (int num in numbers)
            {
                Console.Write("\t {0}", num);
            }
            Console.Read();

            
        }
    }
}
