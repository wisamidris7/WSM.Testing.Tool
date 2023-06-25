using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSM.Testing.Tool.EFCore.Models
{
    public class Employee : TestBase
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public Section Section { get; set; }
        public int SectionId { get; set; }
    }
}
