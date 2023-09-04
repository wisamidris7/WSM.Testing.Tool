using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSM.Testing.Tool.Models.ModelsDto
{
    public class EmployeeDto : TestBaseDto
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public int SectionId { get; set; }
    }
}
