using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Excel
{
    // Observable
    class Subject
    {
        private readonly List<IObserver> _observers;

        public Subject()
        {
            _observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        // Push Style
        //public void NotifyObserver(int value)
        //{
        //    _observers.ForEach(observer => observer.Update(value));
        //}

        // Pull Style
        public void NotifyObserver()
        {
            _observers.ForEach(observer => observer.Update());
        }
    }
}
