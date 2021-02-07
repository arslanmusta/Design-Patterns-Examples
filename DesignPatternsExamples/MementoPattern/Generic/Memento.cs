using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace MementoPattern.Generic
{
    public class Memento
    {
        private readonly XmlSerializer _serializer;
        private readonly byte[] _serializedObject;
        
        public Memento(Originator obj)
        {
            _serializer = new XmlSerializer(obj.GetType());
            
            using var stream = new MemoryStream();
            _serializer.Serialize(stream, obj);
            
            stream.Seek(0, SeekOrigin.Begin);
            _serializedObject = stream.ToArray();
            stream.Close();
        }

        public Originator GetObject()
        {
            using var stream = new MemoryStream(_serializedObject);
            stream.Seek(0, SeekOrigin.Begin);
            var result =  _serializer.Deserialize(stream) as Originator;
            stream.Close();
            
            return result;
        }
    }
}
