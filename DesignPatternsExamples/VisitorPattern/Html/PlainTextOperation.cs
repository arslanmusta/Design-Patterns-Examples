using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Html
{
    class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("text-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("text-anchor");
        }
    }
}
