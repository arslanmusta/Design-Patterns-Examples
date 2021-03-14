using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Words
{
    abstract class Iterator : IEnumerator
    {
        public abstract object Current { get; }

        public abstract bool MoveNext();

        public abstract void Reset();

    }
}
