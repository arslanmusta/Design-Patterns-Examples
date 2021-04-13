using System;
using System.Collections.Generic;
using System.Text;
using AdapterPattern.ImageProcess.AvaFilters;

namespace AdapterPattern.ImageProcess
{
    class CaramelFilter : IFilter
    {
        private readonly Caramel _caramel;

        public CaramelFilter(Caramel caramel)
        {
            _caramel = caramel;
        }

        public void Apply(Image image)
        {
            _caramel.Init();
            _caramel.Render(image);
        }
    }
}
