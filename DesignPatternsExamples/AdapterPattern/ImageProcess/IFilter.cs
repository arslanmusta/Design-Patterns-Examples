using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.ImageProcess
{
    interface IFilter
    {
        void Apply(Image image);
    }
}
