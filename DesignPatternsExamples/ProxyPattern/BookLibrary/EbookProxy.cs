using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.BookLibrary
{
    class EbookProxy : IEbook
    {
        public string FileName { get; }
        private RealEbook _ebook;

        public EbookProxy(string fileName)
        {
            FileName = fileName;
        }

        public void Show()
        {
            if (_ebook == null)
            {
                _ebook = new RealEbook(FileName);
            }

            _ebook.Show();
        }
    }
}
