using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.ImageStore
{
    public class ImageStorage
    {
        public void Store(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(fileName);
            
            filter.Apply(fileName);
        }
    }
}
