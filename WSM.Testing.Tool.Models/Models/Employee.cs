using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSM.Testing.Tool.Models.Models
{
    public class Employee : TestBase
    {
        public Employee() { }
        public Employee(string name,string fullName, string phone, int sectionId)
        {
            Name = name;
            FullName = fullName;
            Phone = phone;
            SectionId = sectionId;
        }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public Section Section { get; set; }
        public int SectionId { get; set; }
        public override string ToString()
        {
            return $@"----
Id:{Id}
Name:{Name}
FullName:{FullName}
SectionId:{SectionId}
----";
        }
    }
}
