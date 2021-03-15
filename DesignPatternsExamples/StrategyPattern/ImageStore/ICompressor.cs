using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.ImageStore
{
    public interface ICompressor
    {
        void Compress(string fileName);
    }
}
