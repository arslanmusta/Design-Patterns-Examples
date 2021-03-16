using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Converter
{
    public abstract class BaseConverter
    {
        protected abstract string Serialize(Person person);

        protected abstract Person Deserialize(string objectString);

        public string Convert(string objectString)
        {
            return Serialize(Deserialize(objectString));
        }
    }
}
