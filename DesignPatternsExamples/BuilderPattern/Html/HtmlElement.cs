using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Html
{
    public class HtmlElement
    {
        private readonly string _name;

        private readonly string _text;

        private const int IndentSize = 4;

        public List<HtmlElement> Children { get; }

        public HtmlElement(string name, string text = null)
        {
            _name = name;
            _text = text;
            Children = new List<HtmlElement>();
        }

        private StringBuilder ToStringPresentation(StringBuilder parent, int indentLevel)
        {
            var indent = new string(' ', IndentSize * indentLevel);
            parent.AppendLine($"{indent}<{_name}>");
            if (!string.IsNullOrWhiteSpace(_text))
            {
                var textIndent = new string(' ', IndentSize * (indentLevel + 1));
                parent.AppendLine($"{textIndent}{_text}");
            }
            Children.ForEach(child => child.ToStringPresentation(parent, indentLevel + 1));
            parent.AppendLine($"{indent}</{_name}>");

            return parent;
        }

        public override string ToString()
        {
            return ToStringPresentation(new StringBuilder(), 0).ToString();
        }
    }
}