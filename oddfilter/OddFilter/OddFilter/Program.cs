using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            OddFilter(numbers);
            List<int> oddElements = OddFilter(new List<int> { 1, 2, 3, 4, 5 });


            PrintList(oddElements);

            Console.ReadLine();
        }

        private static void OddFilter(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    i 
                } 
            }
        }

        private static void PrintList(List<int> oddElements)
        {
            foreach (int element in oddElements)
            {
                Console.Write("{0} ", oddElements);
                
            }
        }
    }
}