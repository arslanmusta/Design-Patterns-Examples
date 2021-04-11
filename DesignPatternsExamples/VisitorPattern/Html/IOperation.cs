using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Html
{
    interface IOperation
    {
        void Apply(HeadingNode heading);

        void Apply(AnchorNode anchor);
    }
}
