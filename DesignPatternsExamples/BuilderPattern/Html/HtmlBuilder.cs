namespace BuilderPattern.Html
{
    public class HtmlBuilder
    {
        private readonly string _rootName;

        private readonly HtmlElement _root;

        public HtmlBuilder(string rootName)
        {
            _rootName = rootName;
            _root = new HtmlElement(rootName);
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            _root.Children.Add(new HtmlElement(childName, childText));

            return this;
        }

        public HtmlBuilder AddChild(HtmlBuilder builder)
        {
            _root.Children.Add(builder._root);

            return this;
        }

        public string ToHtml()
        {
            return _root.ToString();
        }
    }
}