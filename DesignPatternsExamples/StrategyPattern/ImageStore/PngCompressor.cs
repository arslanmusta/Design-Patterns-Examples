using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.ImageStore
{
    public class PngCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using PNG");
        }
    }
}
