using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Words
{
    class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;

        private int _position = -1;

        private readonly bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse)
            {
                _position = _collection.GetItems().Count;
            }
        }

        public override object Current => _collection.GetItems()[_position];

        public override bool MoveNext()
        {
            var updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _position = _reverse ? _collection.GetItems().Count - 1 : 0;
        }
    }
}
