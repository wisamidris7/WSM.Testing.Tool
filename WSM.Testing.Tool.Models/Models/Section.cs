using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSM.Testing.Tool.Models.Models
{
    public class Section : TestBase
    {
        public Section() { }
        public Section(int id, string name, int maxEmployees)
        {
            Id = id;
            Name = name;
            MaxEmployees = maxEmployees;
        }

        public int MaxEmployees { get; set; }
        public List<Employee> Employees { get; set; }
        public override string ToString()
        {
            return $@"----
Id:{Id}
Name:{Name}
MaxEmployees:{MaxEmployees}
----";
        }

    }
}
