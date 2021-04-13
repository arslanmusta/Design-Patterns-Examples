using System;
using System.Collections.Generic;
using System.Text;
using AdapterPattern.ImageProcess.AvaFilters;

namespace AdapterPattern.ImageProcess
{
    class CaramelAdapter : Caramel, IFilter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}
