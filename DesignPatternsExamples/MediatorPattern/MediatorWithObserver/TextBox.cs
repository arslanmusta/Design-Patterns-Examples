using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.MediatorWithObserver
{
    class TextBox : UIControl
    {
        private string _content;
        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                NotifyEventHandlers();   
            }
        }
    }
}
