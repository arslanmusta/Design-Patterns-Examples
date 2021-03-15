using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.ImageStore
{
    public interface IFilter
    {
        void Apply(string fileName);
    }
}
