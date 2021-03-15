using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.ImageStore
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying B&W filter");
        }
    }
}
