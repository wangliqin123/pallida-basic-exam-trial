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
            // Create an OddFilter function that takes a list as a parameter,
            // and returns a new list with every odd element from the orignal list
            List<int> oddElements = OddFilter(new List<int> { 1, 2, 3, 4, 5 });
            
            // In case of the example input above, the given PrintList function should print 1 3 5 
            PrintList(oddElements);

            Console.ReadLine();
        }

        public static void OddFilter(List<int> oddElements)
        {
            for (int i = 0; i < oddElements.Count; i++)
            {
                Console.WriteLine(i % 2 == 0 ? "even" : "odd");
            }
        }

        private static void PrintList(List<int> oddElements)
        {
            foreach (int element in oddElements)
            {
                Console.Write("{0} ", element);
            }
        }
    }
}