using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.UserInterface
{
    class ListBox : UIControl
    {
        private string _selection;
        public string Selection
        {
            get => _selection;
            set
            {
                _selection = value;
                Owner.Changed(this);
            }
        }

        public ListBox(DialogBox owner) : base(owner)
        {
        }
    }
}
