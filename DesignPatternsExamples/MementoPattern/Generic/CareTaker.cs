using System.Collections.Generic;
using System.Linq;

namespace MementoPattern.Generic
{
    public class CareTaker
    {
        private readonly List<Memento> _mementos = new List<Memento>();

        public void Push(Memento memento)
        {
            _mementos.Add(memento);
        }

        public Memento Pop()
        {
            var lastMemento = _mementos.Last();
            _mementos.Remove(lastMemento);

            return lastMemento;
        }
    }
}
