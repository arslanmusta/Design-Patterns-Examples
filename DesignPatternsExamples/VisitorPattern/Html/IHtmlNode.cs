using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Html
{
    interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}
