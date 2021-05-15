using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Code
{
    public class ClassElement
    {
        public string Name;
        public readonly List<(string, string)> Fields  = new();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {Name}");
            sb.AppendLine("{");
            Fields.ForEach(field => sb.AppendLine($"   public {field.Item1} {field.Item2};"));
            sb.Append('}');

            return sb.ToString();
        }
    }
}