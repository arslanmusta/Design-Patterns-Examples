using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Department
{
    class HRDepartment : IIterable
    {
        private Employee[] _employees;

        public HRDepartment(Employee[] employees)
        {
            _employees = employees;
        }

        public IIterator GetIterator()
        {
            return new ArrayIterator(_employees);
        }
    }
}
