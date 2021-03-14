using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Words
{
    class WordsCollection : IteratorAggregate
    {
        private readonly List<string> _collection = new List<string>();

        private bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<string> GetItems()
        {
            return _collection;
        }

        public void Push(string item)
        {
            _collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}
