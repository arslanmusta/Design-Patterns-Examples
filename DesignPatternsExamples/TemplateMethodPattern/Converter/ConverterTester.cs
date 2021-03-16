using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Converter
{
    public static class ConverterTester
    {
        public static void Test()
        {
            var json = "{'name':'Albert Einstein', 'age': 50}";
            var converter = new JsonToXmlConverter();
            var result = converter.Convert(json);
            Console.WriteLine(result);

            var xml = @"<?xml version=""1.0"" encoding=""utf-16""?>
                        <Person xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
                          <Name>Albert Einstein</Name>
                          <Age>50</Age>
                        </Person>";

            var converter2 = new XmlToJsonConverter();
            var result2 = converter2.Convert(xml);
            Console.WriteLine(result2);
        }
    }
}
