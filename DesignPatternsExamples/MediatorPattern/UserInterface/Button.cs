using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.UserInterface
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
                Owner.Changed(this);
            }
        }

        public Button(DialogBox owner) : base(owner)
        {
        }
    }
}
