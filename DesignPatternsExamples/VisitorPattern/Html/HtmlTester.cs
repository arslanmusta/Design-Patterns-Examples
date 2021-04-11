using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Html
{
    static class HtmlTester
    {
        internal static void Test()
        {
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());
            
            document.Execute(new HighlightOperation());
            document.Execute(new PlainTextOperation());
        }
    }
}
