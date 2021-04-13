using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.ImageProcess
{
    class ImageView
    {
        private readonly Image _image;

        public ImageView(Image image)
        {
            _image = image;
        }

        public void Apply(IFilter filter)
        {
            filter.Apply(_image);
        }
    }
}
