using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.ImageProcess.AvaFilters
{
    class Caramel
    {
        public void Init()
        {

        }

        public void Render(Image image)
        {
            Console.WriteLine("Applying Caramel Filter");
        }
    }
}
