using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Editor
{
    public class HtmlDocument
    {
        public string Content { get; set; }

        public void MakeBold()
        {
            Content = $"<b>{Content}</b>";
        }
        
    }
}
