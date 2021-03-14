using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Department
{
    static class DepartmentTester
    {
        public static void Test()
        {
            var hr = new HRDepartment(new Employee[]
            {
                new Employee("Donald Trump", "RETIRED POTUS"),
                new Employee("Joe Biden", "POTUS")
            });

            var itr = hr.GetIterator();

            while (itr.HasNext())
            {
                Console.WriteLine(itr.GetNext());
            }

            var it = new ITDepartment(new List<Employee>()
            {
                new Employee("Melania Trump", "RETIRED FLOTUS"),
                new Employee("Jill Biden", "FLOTUS")
            });

            var itr2 = it.GetIterator();

            while (itr2.HasNext())
            {
                Console.WriteLine(itr2.GetNext());
            }
        }
    }
}
