using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Html
{
    class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Highlight-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Highlight-anchor");
        }
    }
}
