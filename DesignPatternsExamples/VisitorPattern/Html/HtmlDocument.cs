using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Html
{
    class HtmlDocument
    {
        private readonly List<IHtmlNode> _nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node)
        {
            _nodes.Add(node);
        }

        public void Execute(IOperation operation)
        {
            _nodes.ForEach(node => node.Execute(operation));
        }
    }
}
