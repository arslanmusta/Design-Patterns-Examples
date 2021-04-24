using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.BookLibrary
{
    class Library
    {
        private Dictionary<string, IEbook> _ebooks = new Dictionary<string, IEbook>();
        public void Add(IEbook ebook)
        {
            _ebooks.Add(ebook.FileName, ebook);
        }

        public void OpenEbook(string fileName)
        {
            _ebooks[fileName].Show();
        }
    }
}
