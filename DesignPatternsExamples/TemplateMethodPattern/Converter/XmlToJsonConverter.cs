using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace TemplateMethodPattern.Converter
{
    public class XmlToJsonConverter : BaseConverter
    {
        protected override string Serialize(Person person)
        {
            return JsonConvert.SerializeObject(person);
        }

        protected override Person Deserialize(string objectString)
        {
            var serializer = new XmlSerializer(typeof(Person));
            using var textReader = new StringReader(objectString);
            return serializer.Deserialize(textReader) as Person;
        }
    }
}
