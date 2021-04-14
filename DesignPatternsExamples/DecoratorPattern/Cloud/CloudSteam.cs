using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Cloud
{
    class CloudSteam : IStream
    {
        public void Write(string data)
        {
            Console.WriteLine("Storing " + data);
        }
    }
}
