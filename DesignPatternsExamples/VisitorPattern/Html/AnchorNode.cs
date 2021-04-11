﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Html
{
    class AnchorNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
