using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSM.Testing.Tool.EFCore.Models
{
    public class Section : TestBase
    {
        public int MaxEmployees { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
