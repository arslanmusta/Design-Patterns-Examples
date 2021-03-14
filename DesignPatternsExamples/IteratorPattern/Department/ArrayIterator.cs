using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Department
{
    internal class ArrayIterator : IIterator
    {
        private readonly object[] _objects;
        private int _index = 0;

        public ArrayIterator(object[] objects)
        {
            _objects = objects;
        }

        public bool HasNext()
        {
            return _objects.Length > _index;
        }

        public object GetNext()
        {
            return _objects[_index++];
        }
    }
}
