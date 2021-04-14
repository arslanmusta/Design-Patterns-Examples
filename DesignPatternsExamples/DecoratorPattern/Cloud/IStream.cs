using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Cloud
{
    interface IStream
    {
        void Write(string data);
    }
}
