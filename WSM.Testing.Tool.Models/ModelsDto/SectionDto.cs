using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSM.Testing.Tool.Models.ModelsDto
{
    public class SectionDto : TestBaseDto
    {
        public int MaxEmployees { get; set; }
        public List<EmployeeDto> Employees { get; set; }
    }
}
