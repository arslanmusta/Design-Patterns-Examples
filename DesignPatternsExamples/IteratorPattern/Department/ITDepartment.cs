using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Department
{
    class ITDepartment
    {
        private List<Employee> _employees;

        public ITDepartment(List<Employee> employees)
        {
            _employees = employees;
        }

        public IIterator GetIterator()
        {
            return new ListIterator(_employees.Cast<object>().ToList());
        }
    }
}
