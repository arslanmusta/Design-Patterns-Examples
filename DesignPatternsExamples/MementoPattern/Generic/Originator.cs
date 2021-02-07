using System;
using System.Collections.Generic;
using System.Text;
using MementoPattern.Generic;

namespace MementoPattern.Generic
{
    [Serializable]
    public abstract class Originator
    {

        public Memento CreateMemento()
        {
            return new(this);
        }

        public abstract void Restore(Memento memento);
        
    }
}
