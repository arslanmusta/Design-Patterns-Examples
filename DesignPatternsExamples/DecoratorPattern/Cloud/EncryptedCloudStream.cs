using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Cloud
{
    class EncryptedCloudStream : IStream
    {
        private readonly IStream _stream;

        public EncryptedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var encrypted = Encrypt(data);
            _stream.Write(encrypted);
        }

        private string Encrypt(string data)
        {
            return "^'+^'%+'^/&^+'&/@";
        }
    } 
}
