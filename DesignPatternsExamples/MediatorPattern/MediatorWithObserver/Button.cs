using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.MediatorWithObserver
{
    class Button : UIControl
    {
        private bool _isEnabled;

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                NotifyEventHandlers();
            }
        }
    }
}
