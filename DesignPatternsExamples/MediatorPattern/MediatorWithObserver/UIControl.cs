using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.MediatorWithObserver
{
    abstract class UIControl
    {
        private readonly List<Action> _eventHandlers = new List<Action>();

        public void AddEventHandler(Action eventHandler)
        {
            _eventHandlers.Add(eventHandler);
        }

        protected void NotifyEventHandlers()
        {
            _eventHandlers.ForEach(observer => observer.Invoke());
        }
    }
}
