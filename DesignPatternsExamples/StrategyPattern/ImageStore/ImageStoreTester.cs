using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.ImageStore
{
    public static class ImageStoreTester
    {
        public static void Test()
        {
            var imageStore = new ImageStorage();
            
            imageStore.Store("a", new JpegCompressor(), new BlackAndWhiteFilter());
            imageStore.Store("b", new PngCompressor(), new BlackAndWhiteFilter());
        }
    }
}
