using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern.Functional
{
    public abstract class FunctionalBuilder<TSubject, TSelf>
        where TSelf : FunctionalBuilder<TSubject, TSelf>
        where TSubject: new()
    {
        private readonly List<Func<TSubject, TSubject>> _actions = new List<Func<TSubject, TSubject>>();
        
        public TSelf Do(Action<TSubject> action) => AddAction(action);

        public TSubject Build() 
            => _actions.Aggregate(new TSubject(), (subject, func) => func(subject));

        private TSelf AddAction(Action<TSubject> action)
        {
            _actions.Add(p =>
            {
                action(p);
                return p;
            });
            return this as TSelf;
        }
    }
}