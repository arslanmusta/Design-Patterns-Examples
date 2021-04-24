using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.BookLibrary
{
    class LoggingEbookProxy : IEbook
    {
        public string FileName { get; }
        private RealEbook _ebook;

        public LoggingEbookProxy(string fileName)
        {
            FileName = fileName;
        }

        public void Show()
        {
            if (_ebook == null)
            {
                _ebook = new RealEbook(FileName);
            }

            Console.WriteLine("Logging");
            _ebook.Show();
        }
    }
}
