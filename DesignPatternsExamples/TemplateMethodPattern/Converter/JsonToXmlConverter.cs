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
    public class JsonToXmlConverter : BaseConverter
    {
        protected override string Serialize(Person person)
        {
            var serializer = new XmlSerializer(person.GetType());

            using var textWriter = new StringWriter();
            serializer.Serialize(textWriter, person);
            return textWriter.ToString();
        }

        protected override Person Deserialize(string objectString)
        {
            return JsonConvert.DeserializeObject<Person>(objectString);
        }
    }
}
