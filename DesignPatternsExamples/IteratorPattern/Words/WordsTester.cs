using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Words
{
    static class WordsTester
    {
        public static void Test()
        {
            var collection = new WordsCollection();
            collection.Push("First");
            collection.Push("Second");
            collection.Push("Third");

            Console.WriteLine("\nStraight Traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
            
            collection.ReverseDirection();
            Console.WriteLine("\nReverse Traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

        }
    }
}
