using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Department
{
    public class ListIterator : IIterator
    {
        private readonly List<object> _list;

        private int _index = 0;

        public ListIterator(List<object> list)
        {
            _list = list;
        }
        public bool HasNext()
        {
            return _list.Count > _index;
        }

        public object GetNext()
        {
            return _list[_index++];
        }
    }
}
