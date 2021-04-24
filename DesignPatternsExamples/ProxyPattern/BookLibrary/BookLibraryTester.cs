using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.BookLibrary
{
    static class BookLibraryTester
    {
        public static void Test()
        {
            var library = new Library();
            string[] fileNames = {"a", "b", "c"};

            foreach (var fileName in fileNames)
            {
                library.Add(new EbookProxy(fileName));
            }

            library.Add(new LoggingEbookProxy("d"));
            
            library.OpenEbook("a");
            library.OpenEbook("c");
            library.OpenEbook("d");

        }
    }
}
