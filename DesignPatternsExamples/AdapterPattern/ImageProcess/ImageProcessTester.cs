using System;
using System.Collections.Generic;
using System.Text;
using AdapterPattern.ImageProcess.AvaFilters;

namespace AdapterPattern.ImageProcess
{
    static class ImageProcessTester
    {
        internal static void Test()
        {
            var imageView = new ImageView(new Image());
            imageView.Apply(new VividFilter());
            
            // Composition, this is better approach
            imageView.Apply(new CaramelFilter(new Caramel()));
            
            // Inheritance
            imageView.Apply(new CaramelAdapter());
        }
    }
}
