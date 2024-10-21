using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataBindingsApp
{
    public class Employee
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public Company? Company { get; set; }
        public decimal Salary { get; set; }
    }

    public class Company
    {
        public string Title { get; set; } = "";
    }
}
