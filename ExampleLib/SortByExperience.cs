using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLib
{
    public class SortByExperience : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            if (x.Experience > y.Experience) return 1;
            else if (x.Experience < y.Experience) return -1;
            else return 0;
        }
    }
}
