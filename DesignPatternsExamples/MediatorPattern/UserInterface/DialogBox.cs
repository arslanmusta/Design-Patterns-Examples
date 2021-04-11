using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.UserInterface
{
    abstract class DialogBox
    {
        public abstract void Changed(UIControl control);
    }
}
