using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Department
{
    public interface IIterator
    {
        bool HasNext();
        object GetNext();
    }
}
