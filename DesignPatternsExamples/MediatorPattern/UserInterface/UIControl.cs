using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.UserInterface
{
    class UIControl
    {
        protected readonly DialogBox Owner;

        public UIControl(DialogBox owner)
        {
            Owner = owner;
        }
    }
}
